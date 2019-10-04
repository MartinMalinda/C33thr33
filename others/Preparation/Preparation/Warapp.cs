using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation
{
    class Warapp
    {
        static void Main(string[] args)
        {
            Pirate pirate = new Pirate();
            pirate.Report();
            pirate.DrinkSomeRum();
            Pirate JackSparrow = new Pirate("Jack Sparrow", 99, 60);
            JackSparrow.Report();
            JackSparrow.Brawl(pirate);
            JackSparrow.Report();
            pirate.Report();
            Console.ReadLine();

        }
    }
}
