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
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
            Console.WriteLine("How much my friend?");
            int x = int.Parse(Console.ReadLine());
            int charPerLine = (x * 2) - 1;

            for (int i = 0; i < x; i++)
            {
                int spaces = (charPerLine/2)- i;
                while (spaces > 0)
                {
                    Console.Write(" ");
                    spaces--;
                }
                int stars = (i * 2) - 1;

                while (stars > 0)
                {
                    Console.Write("*");
                    stars--;
                }
                int spaces2 = (charPerLine/2) - i;
                while (spaces2 > 0)
                {
                    Console.Write(" ");
                    spaces2--;


                }
                Console.Write("\n\n");

            }

            Console.ReadLine();
            // I know the code is probably way too complicated and it could be done in an 
            // easier way, but I am happy with it :)
        }
    }
}
