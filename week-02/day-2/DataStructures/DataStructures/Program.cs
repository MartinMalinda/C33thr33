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
            Dictionary<string, string> seznamKnih = new Dictionary<string, string>();
            seznamKnih.Add("978-1-60309-452-8", "A Letter to Jo");
            seznamKnih.Add("978-1-60309-459-7", "Lupus");
            seznamKnih.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            seznamKnih.Add("978-1-60309-461-0", "The Lab");

            foreach (var kniha in seznamKnih)
            {
                Console.WriteLine(kniha.Value + " (ISBN: " +  kniha.Key+ ")");
            }
            Console.ReadKey();
        }
    }
}
