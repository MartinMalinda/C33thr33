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
        public int HP { get; private set; } = 100;
        public string Name { get; set; }

        private int xp = 0;
        public int XP
        {
            get { return xp; }
            set
            {
                if (value/100 != xp/100)
                {
                    HP += 33;
                }
                xp = value;
            }
        }
        //public int XP { get; set; }
        public bool isDead { get; private set; } = false;

        public Pirate(string name, int hp, int XP)
        {
            Name = name;
            HP = hp;
            this.XP = XP;
        }

        public Pirate()
        {
            Name = "Pirate" + random.Next(0, 100).ToString();
            HP = 100;
            XP = random.Next(0, 33);
        }

        public void DrinkSomeRum()
        {
            if (isDead)
            {
                Console.WriteLine($"{Name}  is dead");
            }
            else
            {
                HP = HP + ((XP/10)*3);
                XP++;
                Console.WriteLine($"{Name} drank some rum");
            }
        }

        public void HowsItGoingMate()
        {
            if (isDead)
            {
                Console.WriteLine($"{Name}  is dead");
            }
            else if (HP < 100)
            {
                Console.WriteLine("Pour me anudder");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                XP++;
            }
        }
        public void Report()
        {
            if (isDead)
            {
                Console.WriteLine($" I used to be {Name} but now ima dead mate");
            }
            else
            {
                Console.WriteLine($"Ahoy! My name is {Name}, I am lvl {XP/10} pirate. My HP is currently {HP}");
            }
        }

        public void Die()
        {
            HP = 0;
            isDead = true;
        }

        public void Brawl(Pirate enemy)
        {
            if (isDead || enemy.isDead)
            {
                Console.WriteLine("Dead pirates cannot fight!");
            }
            else
            {
                Console.WriteLine($"{Name} and {enemy.Name} are fighting!");
                enemy.HP = enemy.HP - (random.Next(35, 55) - (XP / 10));
                HP = HP - (random.Next(30, 55) - (enemy.XP / 10));
                if (HP < 1)
                {
                    enemy.XP += (XP / 2) + 50;
                    isDead = true;
                }
                else
                {
                    enemy.XP += (XP / 4) + 20;
                }
                if (enemy.HP < 1)
                {
                    XP += (enemy.XP / 2) + 50;
                    enemy.isDead = true;
                }
                else
                {
                    XP += (enemy.XP / 4) + 20;
                }

            }
        }
    }
}
