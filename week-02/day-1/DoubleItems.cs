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
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            int[] numList = { 3, 4, 5, 6, 7 };
            int a;
            foreach (int num in numList)
            {
                a= num * 2;
                Console.WriteLine(a + "");

            }
            Console.ReadKey();

        }
    }
}

