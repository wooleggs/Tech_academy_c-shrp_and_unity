using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orange
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Daily Student Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page are you on?");
            string pagenumber = Console.ReadLine();
            int pgnm = Convert.ToInt32(pagenumber);
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool needhelp = true;
            bool dontneedhelp = false;
            Console.ReadLine();
            Console.WriteLine("Is there any positve expirences you'd like to share? Please be specific.");
            string positiveexp = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hours2 = Convert.ToInt32(hours);
            Console.WriteLine("Thank you for your responces. An instructor will be in contact with you shortly.");
            Console.ReadLine() ;


        }
    }
}
