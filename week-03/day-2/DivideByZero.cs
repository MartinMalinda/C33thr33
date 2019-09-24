using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0

            Console.Write("What is your number?: ");
            int userNumber = int.Parse(Console.ReadLine());

            try
            {
                double answer = 10 / userNumber;
                Console.WriteLine(answer);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
               
            }
            Console.ReadKey();

        }
    }
}
