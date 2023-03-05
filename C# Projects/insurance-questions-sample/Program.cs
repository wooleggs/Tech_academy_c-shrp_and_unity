using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurance_questions_sample
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Good afternoon, and welcome to the New Days Insurance Qualification Questionaire");
            Console.ReadLine();
            Console.WriteLine("In order to accurately determine your eligability, please answer the following questions");
            Console.ReadLine();
            Console.WriteLine("For answers requiring a numerical value, please use number digit values, such as 12, 3, 56, etc..");
            Console.ReadLine(); 
            Console.WriteLine("For all other responces, please simply respond with 'true', or 'false'");
            Console.ReadLine();
            Console.WriteLine("What is your current age in years?");
            string years = Console.ReadLine();
            int age = Convert.ToInt32(years);
            Console.WriteLine("Have you ever recieved a DUI?");
            bool yes = true;
            bool no = false;
            Console.ReadLine() ;
            Console.WriteLine("How many speeding tickets have you been issued? If the anser is none, please input '0'.");
            string speed = Console.ReadLine();
            int tickets = Convert.ToInt32(speed);
            Console.WriteLine("Are you eligible?");
            bool crit1 = (age > 18);
            bool crit2 = (no != yes);
            bool crit3 = (tickets < 3);
            bool eligible = (crit1 && crit2 && crit3);
            Console.WriteLine(eligible);
            Console.ReadLine() ;
        }
    }
}
