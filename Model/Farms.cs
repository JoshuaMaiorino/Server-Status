using System;
using System.Collections.Generic;
using System.Text;

namespace Server_Status.Model
{
    public partial class farms : FarmingSimulator19GameFile
    {
        public override string fileName {
            get 
            {
                return "farms.xml";
            }
        }
    }
}
