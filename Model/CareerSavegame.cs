using System;
using System.Collections.Generic;
using System.Text;

namespace Server_Status.Model
{
    public partial class careerSavegame : FarmingSimulator19GameFile
    {
        public override string fileName {
            get 
            {
                return "careerSavegame.xml";
            }
        }
    }
}
