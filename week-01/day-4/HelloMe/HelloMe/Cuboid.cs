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
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            int x = 5;
            int y = 4;
            int z = 8;

            Console.WriteLine("Surface Area: " + (x * y * 2 + x * z * 2 + z * y * 2));
            Console.WriteLine("Volume: " + (x*z*y));
            Console.ReadLine();

        }
    }
}
