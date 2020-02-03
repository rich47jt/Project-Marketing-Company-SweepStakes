using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SweepStakes
{
    class Simulation
    {

        
        public void CreatingMarketingFirmWithManager(ISweepStakesManager manager)
        {
            Marketing_Firm marketing_Firm;
            marketing_Firm = new Marketing_Firm(manager);
            
        }

        public string ChooseManager()
        {
            Console.WriteLine("What manager do you want Q or S ");
            string  input = Console.ReadLine();
            return input;
        }

        public ISweepStakesManager AddManager(string ManagerType)
        {
            FactoryManager factoryManager = new FactoryManager();
            ISweepStakesManager manager = factoryManager.SetManager(ManagerType);
            return manager;
        }

        public void RunSimulation()
        {
            string input = ChooseManager();
            ISweepStakesManager manager = AddManager(input);
            CreatingMarketingFirmWithManager(manager);
        }
        



    }
}
 