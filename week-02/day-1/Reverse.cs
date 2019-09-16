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
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] aj = { 3, 4, 5, 6, 7 };
            int[] x = new int[aj.Length];

            for (int i = 0; i < aj.Length; i++)
            {
              x[aj.Length - 1 -i] = aj[i];
            }

            for (int i = 0; i < aj.Length; i++)
            {
                aj[i] = x[i];
            }

            foreach (var a in aj)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();

        }
    }
}

