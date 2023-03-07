using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_comparions
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number");
            string aaa = Console.ReadLine();
            int guess = Convert.ToInt32(aaa);
            bool theguess = guess == 3;

           
            while (!theguess)
            {
                switch (guess)
                {
                    case 0:
                        Console.WriteLine("Why start there?");
                        Console.WriteLine("Guess a number");
                        aaa = Console.ReadLine();
                        guess = Convert.ToInt32(aaa);
                        break;
                    case 1:
                        Console.WriteLine("You got it! Just kidding.");
                        Console.WriteLine("Guess a number");
                        aaa = Console.ReadLine();
                         guess = Convert.ToInt32(aaa);
                        break;
                    case 2:
                        Console.WriteLine("Are you guessing one at a time?");
                        Console.WriteLine("Guess a number");
                        aaa = Console.ReadLine();
                        guess = Convert.ToInt32(aaa);
                        break;
                    case 3:
                        Console.WriteLine("You know what? Sure. You got it buddy.");
                        theguess = true;
                        break;
                    default:
                        Console.WriteLine("Are you even trying? Do it again.");
                        Console.WriteLine("Guess a number");
                        aaa = Console.ReadLine();
                        guess = Convert.ToInt32(aaa);
                        break;

                }
            }
            Console.ReadLine();
        }
    }
}
