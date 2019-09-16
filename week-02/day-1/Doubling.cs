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
            // -Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)`

            int basedNum = 123;
            Doubling(basedNum);
            Console.ReadKey();
        }
        static void Doubling( int num)
        {
            Console.WriteLine( num * 2);
           
        }
        
    }
}

