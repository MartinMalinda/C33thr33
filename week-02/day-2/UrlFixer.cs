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
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            string newUrl;
            newUrl = url.Replace("bots", "odds");
            newUrl = newUrl.Insert(5, ":");
            
            Console.WriteLine(newUrl);
            Console.WriteLine("We did it reddit");
            Console.ReadKey();

        }
    }
}
