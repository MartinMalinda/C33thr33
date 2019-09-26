using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Teacher
    {
        public void Teach(Student student)
        {
            student.Learn();
        }
        public void Answer()
        {
            Console.WriteLine("Teacher answered the quesiton");
        }
    }
}
