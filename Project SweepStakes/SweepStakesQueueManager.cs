using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SweepStakes
{
    class SweepStakesQueueManager: ISweepStakesManager
    {
        Queue<SweepStakes> queue;
        public SweepStakesQueueManager()
        {
            queue = new Queue<SweepStakes>();
        }
        public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            
            queue.Enqueue(sweepStakes);

        }

        public SweepStakes GetSweepStakes()
        {
            SweepStakes sweepStakes = queue.Dequeue();
            return sweepStakes;
        }
    }
}
