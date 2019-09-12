using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMe
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean

            string name = "Lucas";
            int age = 30;
            double height = 1.83;
            bool married = false;

            Console.WriteLine("Hello, my name is " + name + ", I am " + age + " years old and " + height +
                "m tall and I am married. Also, the last fact is " + married);
            Console.ReadLine();
        }
    }
}
