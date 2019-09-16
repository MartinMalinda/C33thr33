using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMe
{
    class Program
    {   static int Factorio(int yourNumber)
        {
            int answer = 1;
            for (int i = 1; i <= yourNumber; i++)
            {
                answer = answer * i;
            }
            return answer;
        }

        static void Main(string[] args)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorio(userInput));
            Console.ReadKey();
        }
    }
}

