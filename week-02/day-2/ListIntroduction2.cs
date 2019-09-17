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
            List<string> listA = new List<string> { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            List<string> listB = new List<string> ();
            listB.AddRange(listA);
            Console.WriteLine("ListA:");
            foreach (var name in listA)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine("Does listA contains Durian?:" + listA.Contains("Durian"));
            Console.WriteLine();

            listB.Remove("Durian");

            Console.WriteLine("ListB after removing Durian:");
            
            listA.Insert(4, "Kiwifruit");

            foreach (var name in listA)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine("List A has {0} items, list B has {1} items", listA.Count, listB.Count);
            Console.WriteLine();
            Console.WriteLine("Index of avocado is: " + listA.IndexOf("Avocado"));
            Console.WriteLine("Index of Durian is: " + listB.IndexOf("Durian"));
            listB.AddRange(new string[]{ "Passion Fruit", "Pomelo"});
            Console.WriteLine(listA[2]);

            Console.ReadKey();


        }
    }
}
