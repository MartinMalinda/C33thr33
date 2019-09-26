using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Animal
    {
        public int Hunger { get; set; } = 50;
        public int Thirst { get; set; } = 50;

        public Animal ()
        {
           
        }
        public void Eat ()
        {
            Hunger = Hunger - 1;
        }
        public void Drink ()
        {
            Thirst = Thirst - 1;
        }
        public void Play()
        {
            Hunger++;
            Thirst++;
        }
    }
    
}
