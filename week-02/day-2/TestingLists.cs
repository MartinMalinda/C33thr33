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
            List<int> listofNumers = new List<int>();
            listofNumers.Add(1);
            listofNumers.Add(2);
            listofNumers.Add(3);
            listofNumers.Add(3);
            listofNumers.Add(3);
            listofNumers.Add(2);

            foreach (var number in listofNumers)
            {
                Console.WriteLine(number);
            }
            listofNumers.RemoveAt(1);
            listofNumers.Remove(3);
            Console.WriteLine("___________________removing ________________________");
            foreach (var number in listofNumers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();

        }   
    }
}
