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
            Console.Write("What is your number(max 4 digits please): ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("If we add all the previous numbers, we get " + NumberAdder(number));
            Console.WriteLine("Sum of all the digits is " + SumDigits(number));
            Console.ReadKey();
        }

        public static int SumDigits(int n)
        {
            int sumOfDigits;
            if (n / 10 == 0)
            {
                sumOfDigits = n % 10;
                return sumOfDigits;
            }
            else
            {
                sumOfDigits = (n % 10) + SumDigits(n / 10);
                return sumOfDigits;
            }
        }
        public static int NumberAdder(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + NumberAdder(n - 1);
            }
        }
    }
}
