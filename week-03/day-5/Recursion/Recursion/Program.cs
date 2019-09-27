using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("What is your second number: ");

            int numberTwo = int.Parse(Console.ReadLine());

            Console.Write("The greatest common divisor is: " + Divisor(numberOne, numberTwo));

            Console.ReadKey();
        }
        public static int Divisor(int x, int y)
        {
            int temp;
            if (y > x)
            {
                (y, x) = (x, y);
            }
            if (x % y == 0)
            {
                return y;
            }
            else
            {
                return Divisor(y, x % y);
            }
        }
    }
}

