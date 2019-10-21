using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class StringManipulation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first word: ");
            string wordOne = Console.ReadLine();
            Console.Write("Enter second word: ");
            string wordTwo = Console.ReadLine();
            Anagram(wordOne, wordTwo);
            Palindrome(wordOne, wordTwo);

            Console.ReadKey();
        }
        public static void Palindrome(string first, string second)
        {
            first = first.ToLower();
            second = second.ToLower();
            bool Pal = true;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[second.Length-i-1])
                {
                    Pal = false;
                }
            }
            if (Pal)
            {
                Console.WriteLine($"{first} and {second} are palindromes");
            }
            else
            {
                Console.WriteLine($"{first} and {second} are NOT palindromes");
            }
        }
        public static void Anagram(string first, string second)
        {
            char[] charOne = first.ToLower().ToCharArray();
            char[] charTwo = second.ToLower().ToCharArray();
            Array.Sort(charOne);
            Array.Sort(charTwo);

            if (charOne.ToString() == charTwo.ToString())
            {
                Console.WriteLine($"{first} and {second} are anagrams");
            }
            else
            {
                Console.WriteLine($"{first} and {second} are NOT anagrams");
            }
        }
    }
}
