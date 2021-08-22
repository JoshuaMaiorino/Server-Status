using System;
using System.Collections.Generic;
using System.Text;

namespace Server_Status.Utility
{
    public static class Helper
    {
        public static string GetWeatherEmote( string weather, bool seasons = false )
        {
            if ( seasons )
            {
                switch ( weather )
                {
                    case "0":
                        return ":sunny:";
                    case "1":
                        return ":cloud:";
                    case "2":
                        return ":cloud_rain:";
                    case "3":
                        return ":cloud_snow:";
                    case "4":
                        return ":fog:";
                    case "5":
                        return ":cloud_rain:";
                    case "6":
                        return ":thunder_cloud_rain:";
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
    }
}
