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
             int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            Console.WriteLine("There are " +
                ((60-currentSeconds)+((60-currentMinutes)*60)+((24-currentHours)*60*60)) + " seconds left today");
            Console.ReadLine();
        

        }
    }
}
