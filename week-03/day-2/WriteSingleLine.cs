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
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"

            string fileName = @"C:\Users\lmale\Documents\greenfox\C33thr33\week-03\day-2\my-file.txt";
            Console.Write("Write your name: ");
            string userName = Console.ReadLine();
            try
            {
                WriteIntoFile(fileName, userName);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            Console.ReadKey();

        }
        static void WriteIntoFile(string path, string name)
        {
            File.WriteAllText(path, name);
        }
    }
}
