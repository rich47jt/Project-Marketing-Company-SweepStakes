using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SweepStakes
{
    public static class UserInterface 
    {

        public static string Prompt()
        {
            Console.WriteLine("Wanna win big and take home an awsome prize, enter your info an find out");
            string startingprompt = Console.ReadLine();
            return startingprompt;

        }

        public static Contestant GetUserInformation()
        {
            Contestant contestant = new Contestant();

            Console.WriteLine("Please enter your first name " );
            contestant.firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name ");
            contestant.lastname = Console.ReadLine();
            Console.WriteLine("Please enter your emailadrss ");
            contestant.emailaddress = Console.ReadLine();

            return contestant;
           
        }

        
    }
}
