using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SweepStakes
{
    class SweepSkatesStackManager: ISweepStakesManager
    {
        Stack<SweepStakes> stack;

        public SweepSkatesStackManager()
        {
            stack = new Stack<SweepStakes>();
        }

       public void InsertSweepStakes(SweepStakes sweepStakes)
       {

            
            stack.Push(sweepStakes);
            
       }

       public SweepStakes GetSweepStakes()
       {
           
            
           SweepStakes sweepStakes = stack.Pop();
            return sweepStakes;
       }


    }
}
