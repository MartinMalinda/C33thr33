using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation
{
    class Pirate
    {
        public static Random random = new Random();
        int hp = 100;
        public int HP
        {
            get
            {
                return hp;
            }
            set
            {
                if (value <= 0 || value > 100)
                {
                    hp = value;
                }
                else
                {
                    hp = 100;
                }
            }
        }
        public string Name { get; set; }
        private int xp;

        public Pirate(string name, int hp, int xp)
        {
            Name = name;
            HP = hp;
            this.xp = xp;
        }

        public Pirate()
        {
            Name = "Pirate" + random.Next(0, 100).ToString();
            HP = 100;
            xp = 0;
        }

        public void DrinkSomeRum()
        {
            if (HP < 1)
            {
                Console.WriteLine("He is dead");
            }
            else
            {
                HP = HP + 5;
                xp++;
                Console.WriteLine($"{Name} drank some rum");
            }
        }

        public void HowsItGoingMate()
        {
            if (HP < 1)
            {
                Console.WriteLine("He is dead");
            }
            else if (HP < 100)
            {
                Console.WriteLine("Pour me anudder");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                xp++;
            }
        }
        public void Report()
        {
            if (HP<1)
            {
                Console.WriteLine("Ima dead mate");
            }
            else
            {
                Console.WriteLine($"Ahoy! My name is {Name}, I am lvl {xp / 10} pirate. My HP is currently {HP}");
            }
        }
        public void Die()
        {
            HP = 0;
        }

        public void Brawl(Pirate enemy)
        {
            if (HP < 1)
            {
                Console.WriteLine("Dead pirates cannot fight!");
            }
            else
            {
                Console.WriteLine($"{Name} and {enemy.Name} are fighting!");
                enemy.HP = enemy.HP - (random.Next(35, 65) - (xp / 10));
                HP = HP - (random.Next(35, 60) - (enemy.xp / 10));
                if (HP < 1)
                {
                    enemy.xp += (xp / 2) + 50;
                }
                else
                {
                    enemy.xp += (xp / 4) + 20;
                }
                if (enemy.HP < 1)
                {
                    xp += (enemy.xp / 2) + 50;
                }
                else
                {
                    xp += (enemy.xp / 4) + 20;
                }

            }
        }
    }
}
