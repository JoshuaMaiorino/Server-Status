using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Collections.Generic;
using System.Net;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Server_Status.Model;
using Server_Status.Utility;
using System.Text;
using System.Runtime.CompilerServices;

namespace Server_Status
{
    class Program
    {
        static void Main( string[] args )
        {
            //WeatherUpdateToDiscord();
            ModCheck();
        }

        private static void ModCheck()
        {
            IConfiguration Config = new ConfigurationBuilder()
                .AddJsonFile( "appSettings.json" )
                .Build();

            var games = Config.GetSection( "Games" ).GetChildren();

            foreach ( var game in games )
            {
                var ftpFiles = new FTPClient();
                string webhook = game.GetSection( "WebhookURL" ).Value;
                string saveGameSlot = game.GetSection( "SaveGame" ).Value;

                var ftp = new FTPClient();
                ftp.username = game.GetSection( "FTP:UserName" ).Value;
                ftp.password = game.GetSection( "FTP:Password" ).Value;
                ftp.ip = game.GetSection( "FTP:IpAddress" ).Value;
                ftp.port = game.GetSection( "FTP:Port" ).Value;

                var saveGame = ftp.GetFile<careerSavegame>( saveGameSlot );
                var vehicles = ftp.GetFile<vehicles>( saveGameSlot );
                var items = ftp.GetFile<items>( saveGameSlot );

                var Mods = saveGame.mod
                    .Select( x => new Mod() { ModName = x.modName, Title = x.title } )
                    .ToList();

                var ModsInUse = vehicles.vehicle
                    .Select( x => x.modName )
                    .Distinct()
                    .ToList();

                ModsInUse.AddRange(
                    items.item
                        .Select( x => x.modName )
                        .Distinct()
                        .ToList() );

                ModsInUse.Add( Path.GetFileNameWithoutExtension( saveGame.settings.mapId ) );

                var modsNotInUse = Mods
                    .Where( x => !ModsInUse.Any( y => y == x.ModName ) )
                    .OrderBy( x => x.ModName );

                foreach( var mod in modsNotInUse )
                {
                    Console.WriteLine( $"{mod.ModName} - {mod.Title}" );
                }

            }

        }

        private static void WeatherUpdateToDiscord()
        {
            IConfiguration Config = new ConfigurationBuilder()
                .AddJsonFile( "appSettings.json" )
                .Build();

            var games = Config.GetSection( "Games" ).GetChildren();

            foreach ( var game in games )
            {

                var ftpFiles = new FTPClient();
                string webhook = game.GetSection( "WebhookURL" ).Value;
                string saveGameSlot = game.GetSection( "SaveGame" ).Value;

                int currentDay = 0;
                string currentTime = "";
                string currentWeather = "";
                string mapName = "";
                string currentSeason = "";
                List<KeyValuePair<string, string>> forecast = null;

                var ftp = new FTPClient();
                ftp.username = game.GetSection( "FTP:UserName" ).Value;
                ftp.password = game.GetSection( "FTP:Password" ).Value;
                ftp.ip = game.GetSection( "FTP:IpAddress" ).Value;
                ftp.port = game.GetSection( "FTP:Port" ).Value;

                // Get Enviornment Details

                var enviornment = ftp.GetFile<environment>( saveGameSlot );

                if ( enviornment != null )
                {
                    currentDay = enviornment.currentDay;
                    currentTime = TimeSpan.FromMinutes( ( double ) enviornment.dayTime ).AsDiscordEmote();

                    if ( enviornment.weather != null )
                    {
                        currentWeather = Helper.GetWeatherEmote( enviornment.weather.forecast.FirstOrDefault().typeName );
                    }
                }

                var saveGame = ftp.GetFile<careerSavegame>( saveGameSlot );

                if ( saveGame != null )
                {
                    mapName = saveGame.settings.mapTitle;
                }

                var seasonData = ftp.GetFile<seasons>( saveGameSlot );

                if ( seasonData != null )
                {
                    seasonData.CurrentDay = currentDay;
                    currentSeason = seasonData.ToString();

                    forecast = seasonData.Forecast;

                    var currentWeatherEvent = seasonData.weather.events.Where( x => x.startDay == currentDay
                                                                                && x.startTime * 60 < enviornment.dayTime
                                                                                && x.endTime * 60 >= enviornment.dayTime )
                                                                    .FirstOrDefault();

                    currentWeather = Helper.GetWeatherEmote( currentWeatherEvent.weatherType.ToString(), true );



                }

                var dcRequest = WebRequest.Create( webhook );
                dcRequest.ContentType = "application/json";
                dcRequest.Method = "Post";
                var fields = new List<Field>();

                if ( mapName != null )
                {
                    fields.Add( new Field() { name = "Game", value = mapName, inline = false } );
                }
                if ( !string.IsNullOrEmpty( currentWeather ) )
                {
                    fields.Add( new Field() { name = "Weather", value = currentWeather, inline = true } );
                }

                if ( !string.IsNullOrEmpty( currentSeason ) )
                {
                    fields.Add( new Field() { name = "Day", value = currentSeason, inline = true } );
                }
                if ( !string.IsNullOrEmpty( currentTime ) )
                {
                    fields.Add( new Field() { name = "Time", value = currentTime, inline = true } );
                }

                if ( forecast != null )
                {
                    var sb = new StringBuilder();

                    foreach ( var item in forecast )
                    {
                        sb.AppendLine( string.Format( "{0}: {1}", item.Key, item.Value ) );
                    }

                    fields.Add( new Field() { name = "Forecast", value = sb.ToString(), inline = false } );

                }

                DiscordMessage message = new DiscordMessage();
                message.username = "Server Status Update";
                message.embeds = new List<Embed>();
                message.embeds.Add( new Embed() { fields = fields } );
                using ( var streamWriter = new StreamWriter( dcRequest.GetRequestStream() ) )
                {
                    streamWriter.Write( JsonSerializer.Serialize( message ) );
                }

                try
                {
                    var httpResponse = dcRequest.GetResponse();
                    using ( var streamReader = new StreamReader( httpResponse.GetResponseStream() ) )
                    {
                        var result = streamReader.ReadToEnd();
                        Console.WriteLine( result );
                    }
                }
                catch ( Exception ex )
                {
                    Console.WriteLine( ex.Message );
                }
            }
        }
    }

}