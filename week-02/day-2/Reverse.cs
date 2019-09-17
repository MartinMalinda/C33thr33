using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static string Reverse(string text)
        {
            char[] pismenka = text.ToCharArray();
            for (int i = 0; i < text.Length ; i++)
            {
                pismenka[i] = text[text.Length - 1 - i];
            }
            text = string.Join("", pismenka);
            return (text);
        }

        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reverse(reversed));
            Console.ReadKey();

        }
    }
}
