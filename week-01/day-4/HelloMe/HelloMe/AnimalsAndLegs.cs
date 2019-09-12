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
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            int chicken = int.Parse(Console.ReadLine());
            int pig = int.Parse (Console.ReadLine());
            Console.WriteLine("There are " + ((chicken * 2) + (pig * 4) + " kegs"));
            Console.ReadLine();
        }
    }
}
