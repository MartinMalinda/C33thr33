using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; private set; } = "Jane Doe";
        public int Age { get; private set; } = 30;
        public string Gender { get; private set; } = "female";

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public Person()
        {

        }
        public virtual void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2}.", Name, Age, Gender);
        }
        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
