using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SweepStakes
{
    class SweepStakes
    {
        Dictionary<int, Contestant> contestants;
        private string name;

       
        public SweepStakes(string name)
        {
            Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
            this.Name = name;

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        public void RegisterContestent(Contestant contestant)
        {
            contestant.RegistrationNumber = contestants.Count;
            contestants.Add(contestant.RegistrationNumber, contestant);


        }

        public void PickWinner() 
        {
     
            Random random = new Random();
            int rgn = random.Next(0,contestants.Count);
            Contestant winner = contestants[rgn];
            
        }

        public void PrintConstestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestants First name, Last name  " + contestant.firstname, contestant.lastname);
            Console.WriteLine("Contestants emailaddress " + contestant.emailaddress);
            Console.ReadLine();
            
        }
    }
}
