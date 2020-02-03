using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SweepStakes
{
    class Marketing_Firm
    {
        ISweepStakesManager manager;
        public Marketing_Firm(ISweepStakesManager manager)
        {
            this.manager = manager;
         
        }

        public SweepStakes CreateSweepStakes()
        {
            SweepStakes sweepStakes = new SweepStakes();
            manager.InsertSweepStakes(sweepStakes);
            return sweepStakes;
        }

    }
}
