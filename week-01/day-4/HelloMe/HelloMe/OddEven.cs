using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMe
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.

            int x = int.Parse(Console.ReadLine());
            if (x % 2 > 0)
            {
                Console.WriteLine("This number is odd");
            }
            else
            {
                Console.WriteLine("This number is even");
            }
            Console.ReadLine();
        }
    }
}
