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
            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // The path parameter should be a string that describes the location of the file you wish to modify
            // The word parameter should also be a string that will be written to the file as individual lines
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file.

            string fileName = @"C:\Users\lmale\Documents\greenfox\C33thr33\week-03\day-2\anothertxtfile.txt";
            Console.Write("What is your message: ");
            string message = Console.ReadLine();
            Console.Write("How many times?: ");
            int multiply = int.Parse(Console.ReadLine());

            WriteIntoFile(fileName, message, multiply);

            Console.ReadKey();

        }
        static void WriteIntoFile(string path, string msg, int x)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < x; i++)
                {
                    writer.WriteLine(msg);
                }
            }
        }
    }
}
