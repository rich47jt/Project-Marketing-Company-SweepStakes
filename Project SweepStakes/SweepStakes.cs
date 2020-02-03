using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SweepStakes
{
    public class SweepStakes
    {
        Dictionary<int, Contestant> contestants;
        private string name;


        public SweepStakes()
        {
            Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
            Name = name;

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
            Console.WriteLine("this is the winner is " + winner);
            
        }

        public void PrintConstestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestants First name, Last name  " + contestant.firstname);
            Console.WriteLine("Contestants Last name, Last name  " + contestant.lastname);
            Console.WriteLine("Contestants emailaddress " + contestant.emailaddress);
            
        }
    }
}
