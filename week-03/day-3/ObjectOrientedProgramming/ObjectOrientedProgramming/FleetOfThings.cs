using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            var fleet = new Fleet();
            // - You have the `Thing` class
            // - You have the `Fleet` class
            // - You have the `FleetOfThings` class with a `Main` method
            // - Download those, use those
            // - In the Main method create a fleet
            // - Achieve this output:s
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            fleet.Add(new Thing("Get milk"));
            fleet.Add(new Thing("Remove the obstacles"));
            fleet.Add(new Thing("Stand up"));
            fleet.Add(new Thing("Eat lunch"));

            fleet.ListOfThings()[2].Complete();
            fleet.ListOfThings()[3].Complete();
            int x = 0;
            foreach (var item in fleet.ListOfThings())
            {
                if (fleet.ListOfThings()[x].completed == true)
                {
                    Console.WriteLine("[x] " + fleet.ListOfThings()[x].name);
                }
                else
                {
                    Console.WriteLine("[] " + fleet.ListOfThings()[x].name);
                }
                x = x + 1;
            }
                
            Console.ReadKey();
        }
    }
}
