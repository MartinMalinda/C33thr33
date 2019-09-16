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
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`

            int[] ai = { 3, 4, 5, 6, 7 };
            int x = 0;

            foreach (var a in ai)
            {
              
              x = x + a;

            }
            Console.WriteLine(x);
            Console.ReadLine();

        }
    }
}

