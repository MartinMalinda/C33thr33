    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> seznam = new Dictionary<int, string>();
            if (seznam.Count > 0)
            {
                Console.WriteLine("is not empty");
            }
            else
            {
                Console.WriteLine("is empty");
            }
            seznam.Add(97, "a");
            seznam.Add(98, "b");
            seznam.Add(99, "c");
            seznam.Add(65, "A");
            seznam.Add(66, "B");
            seznam.Add(67, "C");

            foreach (var key in seznam.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in seznam.Values)
            {
                Console.WriteLine(value);
            }

            seznam.Add(68, "D");

            Console.WriteLine(seznam.Count);

            Console.WriteLine(seznam[99]);

            seznam.Remove(97);


            if (seznam.ContainsKey(100)== true)
            {
                Console.WriteLine(seznam[100]);
            }
            else
            {
                Console.WriteLine("There is no such key");
            }

            seznam.Clear();


            Console.ReadKey();

        }
    }
}
