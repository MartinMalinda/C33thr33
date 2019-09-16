using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMe
{
    class Program
    {   static int Sum(int sumOfNumbers)
        {
            int answer = 0;
            for (int i = 0; i <= sumOfNumbers; i++)
            {
                answer = answer + i;
            }
            return answer;
        }

        static void Main(string[] args)
        {
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter
            int yourNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(yourNumber));
            Console.ReadKey();
        }
    }
}

