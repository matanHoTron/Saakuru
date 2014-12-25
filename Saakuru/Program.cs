using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saakuru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("* Prints a random integer from 1 to k *");
            Console.WriteLine("* With probability proportional to k  *");
            Console.WriteLine("* In a linearly                       *");
            Console.WriteLine("***************************************");
            Console.WriteLine();
            Console.WriteLine("Enter a k: ");
            int k = int.Parse(Console.ReadLine());

            UnfairRandom unfair = new UnfairRandom(k);
            Console.WriteLine("Unfair Number: " + unfair.Unfairandom());
            Console.WriteLine("Fair Number:   " + unfair.FairRandom());
            Console.WriteLine("Factorial =   " + unfair.Factorial());
        }
    }
}
