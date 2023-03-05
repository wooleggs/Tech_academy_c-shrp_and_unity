using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace income_comparison_program
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            int hourrate1 = 22;
            int hourworked1 = 45;
            Console.WriteLine("Hourly Rate: " + hourrate1);
            Console.WriteLine("Hours Worked per Week: " + hourworked1);
            int paycheck1 = hourworked1 * hourrate1;
            Console.ReadLine() ;
            Console.WriteLine("Person 2");
            int hourrate2 = 35;
            int hourworked2 = 25;
            Console.WriteLine("Hourly Rate: " + hourrate2);
            Console.WriteLine("Hours Worked per Week: " + hourworked2);
            int paycheck2 = hourworked2 * hourrate2;
            Console.ReadLine() ;
            int annual1 = paycheck1 * 52;
            int annual2 = paycheck2 * 52;
            Console.WriteLine("Person 1 Annual Salary: " + annual1);
            Console.WriteLine("Person 2 Annual Salary: " + annual2);
            Console.ReadLine() ;
            Console.WriteLine("Does Person 1 make more money annually, compared to Person 2?");
            bool income = annual1 >= annual2;
            Console.WriteLine(income);
            Console.ReadLine();

        }
    }
}
