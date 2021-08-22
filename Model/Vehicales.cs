using System;
using System.Collections.Generic;
using System.Text;

namespace Server_Status.Model
{
    public partial class vehicles : FarmingSimulator19GameFile
    {
        public override string fileName
        {
            get
            {
                return "vehicles.xml";
            }
        }
    }
}
