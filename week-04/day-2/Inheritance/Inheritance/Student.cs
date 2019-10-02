using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student : Person
    {
        public string PreviousOrganization { get; private set; } = "The School of Life";
        private int skippedDays = 0;

        public Student(string name, int age, string gender, 
            string previousOrganization) : base(name, age, gender)
        {
            PreviousOrganization = previousOrganization;
        }

        public Student()
        {

        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} " +
                "who skipped {4} days from the course already."
                , Name, Age, Gender, PreviousOrganization, skippedDays);
        }
        public void SkipDays(int numberOfDays)
        {
            skippedDays = skippedDays + numberOfDays;
        }

    }
}
