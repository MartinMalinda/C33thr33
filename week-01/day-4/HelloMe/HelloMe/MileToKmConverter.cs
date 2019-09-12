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
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it
            string miles= Console.ReadLine();
            double km = Convert.ToDouble(miles);
            Console.WriteLine(miles + " mile(s) is exactly " + (km * 1.609344) + " kilometre(s)");
            Console.ReadLine();
        }
    }
}
