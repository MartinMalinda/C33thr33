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

            Console.WriteLine("Pirates phase:");
            Console.WriteLine("--------------------------------------------------------------------");
            Pirate pirateOne = new Pirate();
            pirateOne.Report();
            pirateOne.DrinkSomeRum();
            Pirate JackSparrow = new Pirate("Jack Sparrow", 99, 150);
            JackSparrow.Report();
            JackSparrow.Brawl(pirateOne);
            JackSparrow.Report();
            pirateOne.Report();
            JackSparrow.Brawl(pirateOne);
            JackSparrow.Report();
            pirateOne.Report();
            JackSparrow.DrinkSomeRum();
            pirateOne.DrinkSomeRum();

            Console.WriteLine();
            Console.WriteLine("Ship phase: ");
            Console.WriteLine("----------------------------------------------------------------------");

            Ship BlackPearl = new Ship("Black Pearl");
            BlackPearl.ListOfPirates.Add(JackSparrow);
            BlackPearl.ListOfPirates.Add(pirateOne);
            BlackPearl.FillShip(30);
            BlackPearl.ShipReport();
            Ship shipOne = new Ship();
            shipOne.FillShip();
            shipOne.ShipReport();
            Console.WriteLine();
            Console.WriteLine();
            BlackPearl.Battle(shipOne);
            Console.WriteLine();
            BlackPearl.AssignCaptain();
            Console.WriteLine();
            BlackPearl.ShipReport();
            Console.WriteLine();
            shipOne.ShipReport();

            Console.ReadLine();

        }
    }
}
