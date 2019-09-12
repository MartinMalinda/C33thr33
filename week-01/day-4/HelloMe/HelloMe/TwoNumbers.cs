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
           // Create a program that prints a few operations on two numbers: 22 and 13

            // Print the result of 13 added to 22

            // Print the result of 13 substracted from 22

            // Print the result of 22 multiplied by 13

            // Print the result of 22 divided by 13 (as a decimal fraction)

            // Print the integer part of 22 divided by 13

            // Print the remainder of 22 divided by 13

            int a = 22;
            int b = 13;
            Console.WriteLine(b+a);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine((double)a/b);
            Console.WriteLine(a/b);
            Console.WriteLine(a%b);

            Console.ReadLine();
            
        }
    }
}
