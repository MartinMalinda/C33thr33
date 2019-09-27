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

            Console.WriteLine(PowerN(numberOne, numberTwo)); 

            Console.ReadKey();
        }
        public static int PowerN(int x, int y)
        {
            if (y == 1)
            {
                return x;
            }
            else
            {
                return x * PowerN(x, y - 1);
            }
        }
    }
}
