using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Sponsor : Person
    {
        public string Company { get; private set; } = "Google";
        private int hiredStudents = 0;

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            Company = company;
        }
        public Sponsor ()
        {

        }

        public void Hire()
        {
            hiredStudents++;
        }
        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far.", Name, Age, Gender, Company, hiredStudents); ;
        }
        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }


    }
}
