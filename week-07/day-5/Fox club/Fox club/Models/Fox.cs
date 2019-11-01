using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foxclub.Models
{
    public class Fox
    {
        public enum Tricks { KungFu, HTML, BackFlip };

        public string name { get; private set; }
        public string food { get; private set; } 
        public string drink { get; private set; } 
        public List<Tricks> ListOfTricks { get; private set; }

        public Fox(string name)
        {
            this.name = name;
            food = "pizza";
            drink = "red bull";
            ListOfTricks = new List<Tricks>();
            ListOfTricks.Add(Tricks.BackFlip);
        }

        public void ChangeFood (string food)
        {
            this.food = food;
        }

        public void ChangeDrink (string drink)
        {
            this.drink = drink;
        }
    }
}
