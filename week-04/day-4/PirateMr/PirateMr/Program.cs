using System;

namespace PirateMr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Pirate
    {
        public int HP { get; private set; }

        public int Promile { get; private set; }

        public bool IsDrunk { get { return Promile > 3; } }

        public bool IsDead { get { return HP <= 0; } }

        public Pirate()
        {
            HP = 10;
        }

        public void GotHit(int damage)
        {
            HP = HP - damage;
        }

        public void Drink()
        {
            Promile++;
        }
    }
}
