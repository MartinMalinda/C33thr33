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
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful

            string fileName1 = @"C:\Users\lmale\Documents\greenfox\C33thr33\week-03\day-2\anothertxtfile.txt";
            string fileName2 = @"C:\Users\lmale\Documents\greenfox\C33thr33\week-03\day-2\anothertxtfile-copy.txt";
            bool result = false;
            try
            {
                CopyFile(fileName1, fileName2);
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                Console.WriteLine(result);
            }
            Console.ReadKey();

        }
        static void CopyFile(string path1, string path2)
        {
            string[] content = File.ReadAllLines(path1);
            File.WriteAllLines(path2, content);

        }
    }
}
