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
            List<string> names = new List<string>();

            Console.WriteLine(names.Count);

            names.Add("Williams");
            if (names.Count > 0)
            {
                Console.WriteLine("List is not empty");
            }
            else
            {
                Console.WriteLine("List is empty");
            }

            names.Add("James");

            names.Add("Amanda");

            Console.WriteLine(names.Count);

            Console.WriteLine(names[2]);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(i+1 + ". " + names[i]);
            }
            names.RemoveAt(1);
            for (int i = names.Count; i > 0; i--)
            {
                Console.WriteLine(names[i-1]);
            }
            names.Clear();

            Console.WriteLine("___________");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();

            }
        }
    }
