using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Mentor : Person
    {
        private Experience Level = Experience.Intermediate;

        public Mentor(string name, int age, string gender, Experience level):base (name, age, gender)
        {
            Level = level;
        }
        public Mentor()
        {

        }
        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} {3} mentor.", Name, Age, Gender, Level);
        }
    }
}
