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

                string currentDay = "";
                string currentTime = "";
                string currentWeather = "";
                string mapName = "";
                string currentSeason = "";
                string seasonsForcast = "";

                double dayTimeInMinutes = 0;

                var ftp = new FTPFiles();
                ftp.username = game.GetSection( "FTP:UserName" ).Value;
                ftp.password = game.GetSection( "FTP:Password" ).Value;
                ftp.ip = game.GetSection( "FTP:IpAddress" ).Value;
                ftp.port = game.GetSection( "FTP:Port" ).Value;

                // Get Enviornment Details

                var enviornment = ftp.GetFile( Path.Combine( saveGameSlot, FileNames.Environment ) );

                if ( !string.IsNullOrEmpty( enviornment.InnerXml ) )
                {
                    currentDay = enviornment.SelectSingleNode( "/environment/currentDay" ).InnerText;

                    if ( double.TryParse( enviornment.SelectSingleNode( "/environment/dayTime" ).InnerText, out dayTimeInMinutes ) )
                    {
                        currentTime = TimeSpan.FromMinutes( dayTimeInMinutes ).AsDiscordEmote();
                    }
                    var forcastNode = enviornment.SelectSingleNode( "/environment/weather/forecast" );
                    if ( forcastNode != null )
                    {
                        currentWeather = GetWeatherEmote( forcastNode.FirstChild.Attributes["typeName"].Value );
                    }
                }

                var saveGame = ftp.GetFile( Path.Combine( saveGameSlot, FileNames.SaveGame ) );

                if ( !string.IsNullOrEmpty( saveGame.InnerXml ) )
                {
                    mapName = saveGame.SelectSingleNode( "/careerSavegame/settings/mapTitle" ).InnerText;
                }

                var seasons = ftp.GetFile( Path.Combine( saveGameSlot, FileNames.Seasons ) );

                if ( !string.IsNullOrEmpty( seasons.InnerXml ) )
                {
                    var daysPerSeason = int.Parse( seasons.SelectSingleNode( "/seasons/environment/daysPerSeason" ).InnerText );

                    currentSeason = GetCurrentSeason( int.Parse( currentDay ), daysPerSeason );

                    var solTempMax = seasons.SelectSingleNode( "/seasons/weather/soilTemp" ).InnerText;
                    var weatherEvents = seasons.SelectSingleNode( "/seasons/weather/events" );
                    foreach ( XmlNode weatherEvent in weatherEvents.ChildNodes )
                    {
                        double startTime;
                        if ( double.TryParse( weatherEvent.Attributes["startTime"].Value, out startTime ) )
                        {
                            double endTime;
                            if ( double.TryParse( weatherEvent.Attributes["endTime"].Value, out endTime ) )
                            {
                                if ( dayTimeInMinutes == 0 ||
                                    ( dayTimeInMinutes >= startTime * 60
                                    && dayTimeInMinutes < endTime * 60 ) )
                                {
                                    currentWeather = GetWeatherEmote( weatherEvent.Attributes["weatherType"].Value, true );
                                    break;
                                }
                            }
                        }
                    }
                }

                var dcRequest = WebRequest.Create( webhook );
                dcRequest.ContentType = "application/json";
                dcRequest.Method = "Post";
                var fields = new List<Field>();
                fields.Add( new Field() { name = "Game", value = mapName, inline = false } );

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
        private static string GetWeatherEmote( string weather, bool seasons=false )
        {
            if( seasons )
            {
                switch ( weather )
                {
                    case "1":
                        return ":cloud:";
                    case "0":
                        return ":sunny:";
                    case "2":
                        return ":partly_sunny:";
                }
            }
            else
            {
                switch ( weather )
                {
                    case "SUN":
                        return ":sunny:";
                    case "RAIN":
                        return ":cloud_rain:";
                    case "CLOUDY":
                        return ":cloud:";
                }
            }

            return weather;
        }

        private static string GetCurrentSeason( int currentDay, int daysPerSeason )
        {
            var daysPerYear = daysPerSeason * 4;
            var currentYear = currentDay / daysPerYear;
            var currentDayOfYear = currentDay - ( daysPerYear * ( currentYear ) );
            var currentSeasonValue = currentDayOfYear / daysPerSeason;
;
            var dayOfSeason = currentDayOfYear % daysPerSeason;

            var partOfSeason = ( double ) dayOfSeason / 3.00;

            string partOfSeasonWord = "";

            if( partOfSeason < .35 )
            {
                partOfSeasonWord = "Early";
            }
            else if ( partOfSeason < .68 )
            {
                partOfSeasonWord = "Mid";
            }
            else
            {
                partOfSeasonWord = "Late";
            }

            return string.Format( "{0} {1:00}/{3} {2}", GetSeasonsEmote( currentSeasonValue.ToString() ), dayOfSeason, GetSeasonName( currentSeasonValue ), partOfSeasonWord );
        }
        private static string GetSeasonName( int season )
        {
            switch ( season )
            {
                case 0:
                    return "Spring";
                case 1:
                    return "Summer";
                case 2:
                    return "Autumn";
                case 4:
                    return "Winter";

            }
            return season.ToString();
        }

        private static string GetSeasonsEmote( string season )
        {
            switch ( season )
            {
                case "0":
                    return ":sunflower:";
                case "1":
                    return ":sunny:";
                case "2":
                    return ":fallen_leaf:";
                case "3":
                    return ":snowflake:";
            }
            return season;
        }
    }
    static class FileNames
    {
        public const string Environment = "environment.xml";
        public const string SaveGame = "careerSavegame.xml";
        public const string Seasons = "seasons.xml";
    }

    public static class TimeSpanExtensions
    {
        public static TimeSpan RoundToNearestMinutes( this TimeSpan input, int minutes )
        {
            var totalMinutes = ( int ) ( input + new TimeSpan( 0, minutes / 2, 0 ) ).TotalMinutes;

            return new TimeSpan( 0, totalMinutes - totalMinutes % minutes, 0 );
        }

        public static string AsDiscordEmote( this TimeSpan input )
        {
            var hours = input.RoundToNearestMinutes( 30 ).Hours;
            var minutes = input.RoundToNearestMinutes( 30 ).Minutes;
            if ( hours == 0 )
                hours = 12;
            else if ( hours > 12 )
            {
                hours -= 12;
            }
            return string.Format( ":clock{2}{3:#}: {0}:{1:00}", input.Hours, input.Minutes, hours, minutes );
        }
    }
}