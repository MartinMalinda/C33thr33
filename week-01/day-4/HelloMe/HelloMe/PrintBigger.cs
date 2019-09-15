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
           // Write a program that asks for two numbers and prints the bigger one

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine(x + " is bigger");
            }
            else if (x == y)
            {
                Console.WriteLine("Both numbers are the same");
            }
            else
            {
                Console.WriteLine(y + " is bigger");
            }

            Console.ReadLine();
        }
    }
}
