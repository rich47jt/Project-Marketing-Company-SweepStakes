using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SweepStakes
{
    public static class UserInterface 
    {
        public static string GetUserInformation()
        {
            
            Console.WriteLine("Hello this is a SweepStakes if you wanna win big please enter your information: First, Last name, and Emailadress ");
            string prompt = Console.ReadLine();



            return prompt;
        }

        
    }
}
