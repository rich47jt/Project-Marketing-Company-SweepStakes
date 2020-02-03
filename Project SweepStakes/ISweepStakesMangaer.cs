using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SweepStakes
{
    public interface ISweepStakesManager 
    {

        void InsertSweepStakes(SweepStakes sweepStakes);
        
             
        

         SweepStakes GetSweepStakes();
        
            
        
    }
}
