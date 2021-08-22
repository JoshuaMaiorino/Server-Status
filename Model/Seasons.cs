using System;
using System.Collections.Generic;
using System.Text;

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
                switch ( this.CurrentSeason )
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
        }

        public override string ToString()
        {  

            return string.Format( "{0} {1:00}/{2} {3}", this.CurrentSeasonEmote, this.CurrentDayOfSeason, this.CurrentPartOfSeason, this.CurrentSeasonName );
        }
    }
}
