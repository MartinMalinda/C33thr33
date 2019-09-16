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
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            int[,] twoDimArray = new int[4, 4];
            for (int x = 0; x < 4; x++)
            {
                twoDimArray[x, x] = 1;
            }

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(twoDimArray[x,y]);
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}

