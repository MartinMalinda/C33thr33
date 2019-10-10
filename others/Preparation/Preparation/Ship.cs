using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation
{
    class Ship
    {
        public string Name { get; private set; }
        public List<Pirate> ListOfPirates = new List<Pirate>();

        public Ship(string name)
        {
            Name = name;
        }

        public Ship()
        {
            Name = "Ship" + Pirate.random.Next(0, 50).ToString();
        }

        public void FillShip(int numberOfPirates)
        {
            for (int i = 0; i < numberOfPirates; i++)
            {
                ListOfPirates.Add(new Pirate());
            }
        }
        public void FillShip()
        {
            for (int i = 0; i < Pirate.random.Next(5, 20); i++)
            {
                ListOfPirates.Add(new Pirate());
            }
        }
        public void ShipReport()
        {
            Console.WriteLine($"Ship {Name} contains {ListOfPirates.Count} pirates. Here is all of them: ");
            foreach (var pirate in ListOfPirates)
            {
                pirate.Report();
            }
        }
        public void Battle(Ship otherShip)
        {
            Console.WriteLine($"BATTLE! {Name} versus {otherShip.Name}!");
            if (ListOfPirates.Count < otherShip.ListOfPirates.Count)
            {
                int j = 0;
                for (int i = 0; i < otherShip.ListOfPirates.Count; i++)
                {
                    ListOfPirates[j].Brawl(otherShip.ListOfPirates[i]);
                    j++;
                    if (j == ListOfPirates.Count)
                    {
                        j = 0;
                    }
                }
            }
            else
            {
                int j = 0;
                for (int i = 0; i < ListOfPirates.Count; i++)
                {
                    ListOfPirates[i].Brawl(otherShip.ListOfPirates[j]);
                    j++;
                    if (j == otherShip.ListOfPirates.Count)
                    {
                        j = 0;
                    }
                }
            }
            Console.WriteLine("RESULTS: ");
            Console.WriteLine($"{Name} : {CalculateScore()} points");
            Console.WriteLine($"{otherShip.Name} : {otherShip.CalculateScore()} points");
        }
        public int CalculateScore()
        {
            int score = 0;
            foreach (var pirate in ListOfPirates)
            {
                if (pirate.isDead == false)
                {
                    score = score + pirate.HP + (pirate.XP / 4);
                }
            }
            return score;
        }
    }
}
