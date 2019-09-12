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
            // Swap the values of the variables
            int a = 123;
            int b = 526;
            int temp;

            temp = b;
            b = a;
            a = temp;
            Console.WriteLine("A is " + a + ", B is " + b);
            Console.ReadLine();

        }
    }
}
