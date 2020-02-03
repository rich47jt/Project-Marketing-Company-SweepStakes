using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SweepStakes
{
    class Simulation
    {
        ISweepStakesManager manager;
        public void CreatingMarketingFirmWithManager()
        {
            Marketing_Firm marketing_Firm;
            marketing_Firm = new Marketing_Firm(manager);
            
            // choose btween two managers in simulation?

            
            
        }
    }
}
