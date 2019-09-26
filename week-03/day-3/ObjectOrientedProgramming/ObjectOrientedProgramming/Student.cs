using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Student
    {
        public Student()
        {

        }
        public Student(string name)
        {

        }

        public void Learn()
        {
            Console.WriteLine("Student used Learn! It is not very effective... ");
        }
        public void Question(Teacher teacher)
        {
            teacher.Answer();
        }

    }
}
