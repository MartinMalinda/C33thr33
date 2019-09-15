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
            Console.WriteLine("How much my friend?");
            int x = int.Parse(Console.ReadLine());
            int charPerLine = (x * 2) - 1;

            for (int i = 0; i <= x; i++)
            {
                int spaces = (charPerLine / 2) - i;
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
                int spaces2 = (charPerLine / 2) - i;
                while (spaces2 > 0)
                {
                    Console.Write(" ");
                    spaces2--;


                }
                Console.Write("\n");

            }

            Console.ReadLine();
        }
    }
}

