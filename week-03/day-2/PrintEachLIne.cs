using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"
            string fileName = @"C:\Users\lmale\Documents\greenfox\C33thr33\week-03\day-2\my-file.txt";

            try
            {
                Console.WriteLine(File.ReadAllText(fileName));
            }
            catch (Exception error)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
