using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Server_Status.Utility;

namespace Server_Status.Model
{
    public partial class seasons : FarmingSimulator19GameFile
    {
        public int CurrentDay { get; set; }        
        public override string fileName
        {
            get
            {
                return "seasons.xml";
            }
        }
        public string CurrentSeasonName 
        { 
            get
            {
                switch ( this.CurrentSeason )
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
                return "";
            }
        }
        public int CurrentSeason
        {
            get
            {
                return this.CurrentDayOfYear / this.environment.daysPerSeason;
            }
        }
        public int CurrentYear
        {
            get
            {
                return this.CurrentDay / this.DaysPerYear;
            }
        }
        public int CurrentDayOfYear
        {
            get
            {
                return this.CurrentDay - ( this.DaysPerYear * ( this.CurrentYear ) );
            }
        }
        public int DaysPerYear { 
            get
            {
                return this.environment.daysPerSeason * 4;
            } 
        }
        public int CurrentDayOfSeason
        {
            get
            {
                return this.CurrentDayOfYear % this.environment.daysPerSeason;
            }
        }
        public string CurrentPartOfSeason
        {
            get
            {
                if ( this.CurrentDayOfSeason / 3.00 < .35 )
                {
                    return "Early";
                }
                else if ( this.CurrentDayOfSeason / 3.00 < .68 )
                {
                    return "Mid";
                }
                return "Late";
            }
        }
        private string CurrentSeasonEmote
        {
            get
            {
                return seasons.GetSeasonEmote( this.CurrentSeason );
            }
        }
        public override string ToString()
        {  
            return string.Format( "{0} {1:00}/{2} {3}", this.CurrentSeasonEmote, this.CurrentDayOfSeason, this.CurrentPartOfSeason, this.CurrentSeasonName );
        }

        public List<KeyValuePair<string,string>> Forecast
        {
            get
            {
                if( this != null &&this.weather != null && this.weather.events != null)
                {
                    var forecast = new List<KeyValuePair<string, string>>();

                    var forecastEvents = this.weather.events
                    .GroupBy( x => new
                    {
                        Time = TimeSpan.FromHours( ( double ) x.startTime ).RoundToNearestHours( 3 ),
                        Day = x.startDay
                    } )
                    .Select( y => new
                    {
                        Time = y.Key.Time,
                        Day = y.Key.Day,
                        WeatherEvents = y.ToList()
                    } )
                    .Take( 8 )
                    .ToList();

                    foreach ( var forecastEvent in forecastEvents )
                    {
                        var day = this.CurrentDay == forecastEvent.Day ? "Today" : "Tomorrow";
                        forecast.Add(
                            new KeyValuePair<string, string>
                            (
                                string.Format( "{0} {1:00}:00", day, forecastEvent.Time.TotalHours ),
                                Helper.GetWeatherEmote( forecastEvent.WeatherEvents.FirstOrDefault().weatherType.ToString(), true )
                            ) );
                    }
                    return forecast;
                }
                return null;
            }
        }
        
        // Staic Methods
        public static string GetForcastEmote( int forecast )
        {
            switch ( forecast )
            {
                case 0:
                    return ":sunny:";
                case 1:
                    return ":partly_sunny:";
                case 2:
                    return ":cloud_snow:";
                case 3:
                    return ":white_sun_rain_cloud:";
                case 4:
                    return ":fog:";
                case 5:
                    return ":cloud:";
                case 6:
                    return ":thunder_cloud_rain:";
                case 7:
                    return ":cloud_snow:";
                case 8:
                    return ":fog:";
                case 9:
                    return ":thunder_cloud_rain:";
                case 10:
                    return ":thunder_cloud_rain:";
            }
            return forecast.ToString();
        }
        public static string GetSeasonEmote( int season )
        {
            switch ( season )
            {
                case 0:
                    return ":sunflower:";
                case 1:
                    return ":sunny:";
                case 2:
                    return ":fallen_leaf:";
                case 3:
                    return ":snowflake:";
            }
            return "";
        }

        public static int[] forcastHours {
            get
            {
                return new int[] { 0, 3, 6, 9, 12, 15, 18, 21 };
            }
        }
    }
}
