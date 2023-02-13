using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp
{
    public class Interviewer
    {
        public void WelcomeCandidate(string? Name)
        {
            Console.WriteLine("Hello "+ Name+" How are you?");
            string? answer=Console.ReadLine();
            if (answer!=null)
            {
                Console.WriteLine("I am glad.");
            }
            else
            {
                Console.WriteLine("Can you answer please?");
                string? answer2 = Console.ReadLine();
            }
           

        }
    }
}
