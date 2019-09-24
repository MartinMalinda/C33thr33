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
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            string fileName = @"C:\Users\lmale\Documents\greenfox\C33thr33\week-03\day-2\my-file.txt";
            Console.Write("Number of lines in the file is: ");
            try
            {
                Console.WriteLine(NumberOfLinesInFile(fileName));
            }
            catch (Exception)
            {
                Console.WriteLine("0");
            }
            Console.ReadKey();

        }
        static int NumberOfLinesInFile(string filename)
        {
            string[] content = File.ReadAllLines(filename);
            int NumberOfLines = 0;
            foreach (var line in content)
            {
                NumberOfLines = NumberOfLines + 1;
            }
            return NumberOfLines;
        }
    }
}
