using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SweepStakes
{
    class FactoryManager
    {
       public ISweepStakesManager SetManager(string ManagementType)
       {
            Simulation simulation = new Simulation();
            ManagementType = simulation.ChooseManager();
            ISweepStakesManager manager;
            manager = null;
            switch(ManagementType)
            {
                case "Queue":
                    manager = new SweepStakesQueueManager();
                    break;
                case "Stack":
                    manager = new  SweepSkatesStackManager();
                    break;
                default:
                    Console.WriteLine("please input correct choice");
                    break;

            }
            return manager;

            
       }
      
    }
}
