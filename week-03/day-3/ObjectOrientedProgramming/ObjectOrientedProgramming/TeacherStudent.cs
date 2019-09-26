using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher firstTeacher = new Teacher();
            //Student studentOne = new Student("Pepa");
            Student studentTwo = new Student();

            studentTwo.Learn();
            studentTwo.Question(firstTeacher);
            firstTeacher.Teach(studentTwo);
            firstTeacher.Answer();
            Console.ReadKey();
        }
    }
}
