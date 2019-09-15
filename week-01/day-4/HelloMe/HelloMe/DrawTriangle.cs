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
             // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
            Console.WriteLine("How much my friend?");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                int y = i;
                while (y > 0)
                {
                    Console.Write("*");
                    y--;

                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
