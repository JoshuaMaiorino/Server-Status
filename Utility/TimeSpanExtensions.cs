using System;
using System.Collections.Generic;
using System.Text;

namespace Server_Status.Utility
{
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
