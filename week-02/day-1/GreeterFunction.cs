using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMe
{
    class Program
    {   static void Greet (string name)
        {
            Console.WriteLine("Greetings dear {0}", name );
        }

        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Green Fox` to it
            // - Create a function called `Greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Green Fox`
            // - Greet `al`

            string al = "Green Fox";
            Greet(al);
            Console.ReadKey();

        }
    }
}

