using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals_practice
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below as they appear.");
            Console.ReadLine();
            Console.WriteLine("Please enter the weight of your package, to the nearest pound. If you do not know the weight of your package, please make an accurate guess.");
            string pounds = Console.ReadLine();
            int weight = Convert.ToInt32(pounds);
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to ship with Package Express. Have a great day!");
            }
            else
            {
                Console.WriteLine("Package within weight limit. Please proceed.");
            }
            Console.ReadLine() ;
            Console.WriteLine("Please enter width of package.");
            string vr1 = Console.ReadLine();
            int width = Convert.ToInt32(vr1);
            Console.WriteLine("Please enter length of package");
            string vr2 = Console.ReadLine();
            int length = Convert.ToInt32(vr2);
            Console.WriteLine("Please enter height of package");
            string vr3 = Console.ReadLine();
            int height = Convert.ToInt32(vr3);
            int pkgsize = width * height * length;
            if (width>50||length>50||height>50)
            {
                Console.WriteLine("Package is too large to be shipped with Package Express. Have a great day!");
            }
            else
            {
                Console.WriteLine("Package within size limit. Please proceed.");
            }
            Console.ReadLine();
            int size = pkgsize * weight;
            int quote = size / 100;
            Console.WriteLine("Your estimated shipping cost is $" + quote);
            Console.ReadLine() ;
        }
    }
}
