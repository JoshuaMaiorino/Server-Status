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

namespace Server_Status
{
    class Program
    {
        static void Main( string[] args )
        { 
            IConfiguration Config = new ConfigurationBuilder()
                .AddJsonFile( "appSettings.json" )
                .Build();

            var games = Config.GetSection( "Games" ).GetChildren();
            
            foreach( var game in games )
            {

                var ftpFiles = new FTPFiles();
                string webhook = game.GetSection( "WebhookURL" ).Value;
                string saveGameSlot = game.GetSection( "SaveGame" ).Value;

                int currentDay = 0;
                string currentTime = "";
                string currentWeather = "";
                string mapName = "";
                string currentSeason = "";

                var ftp = new FTPFiles();
                ftp.username = game.GetSection( "FTP:UserName" ).Value;
                ftp.password = game.GetSection( "FTP:Password" ).Value;
                ftp.ip = game.GetSection( "FTP:IpAddress" ).Value;
                ftp.port = game.GetSection( "FTP:Port" ).Value;

                // Get Enviornment Details

                var enviornment = ftp.GetFile<environment>( saveGameSlot );

                if ( enviornment != null )
                {
                    currentDay = enviornment.currentDay;
                    currentTime = TimeSpan.FromMinutes( (double)enviornment.dayTime ).AsDiscordEmote();

                    if( enviornment.weather != null )
                    {
                        currentWeather = Helper.GetWeatherEmote( enviornment.weather.forecast.FirstOrDefault().typeName );
                    }
                }

                var saveGame = ftp.GetFile<careerSavegame>(  saveGameSlot );

                if ( saveGame != null )
                {
                    mapName = saveGame.settings.mapTitle;
                }

                var seasons = ftp.GetFile<seasons>( saveGameSlot );

                if ( seasons != null )
                {
                    seasons.CurrentDay = currentDay;
                    
                    var daysPerSeason = seasons.environment.daysPerSeason;

                    currentSeason = seasons.ToString();

                    var solTempMax = seasons.weather.soilTemp;

                    var currentWeatherEvent = seasons.weather.events.Where( x => x.startDay == currentDay
                                                                                && x.startTime * 60 < enviornment.dayTime
                                                                                && x.endTime * 60 >= enviornment.dayTime )
                                                                    .FirstOrDefault();
 
                    currentWeather = Helper.GetWeatherEmote( currentWeatherEvent.weatherType.ToString(), true );
                           
                }

                var dcRequest = WebRequest.Create( webhook );
                dcRequest.ContentType = "application/json";
                dcRequest.Method = "Post";
                var fields = new List<Field>();
                
                if( mapName != null )
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

                fields.Add( new Field() { name = "Time", value = currentTime, inline = true } );

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

        private static string GetForcastEmote( string forecast )
        {
            switch ( forecast )
            {
                case "0":
                    return ":sunny:";
                case "1":
                    return ":partly_sunny:";
                case "2":
                    return ":cloud_snow:";
                case "3":
                    return ":white_sun_rain_cloud:";
                case "4":
                    return ":fog:";
                case "5":
                    return ":cloud:";
                case "6":
                    return ":thunder_cloud_rain:";
                case "7":
                    return ":cloud_snow:";
                case "8":
                    return ":fog:";
                case "9":
                    return ":thunder_cloud_rain:";
                case "10":
                    return ":thunder_cloud_rain:";
            }
            return forecast;
        }
    }

}