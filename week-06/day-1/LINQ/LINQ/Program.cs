using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1 \n ");
            int[] num = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var evenNumbers = num.Where(n => n % 2 == 0);
            evenNumbers.ToList().ForEach(n => Console.WriteLine(n));

            Console.WriteLine();
            var evenNumbersQuery = from n in num
                                   where n % 2 == 0
                                   select n;
            foreach (var number in evenNumbersQuery)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Exercise 2
            Console.WriteLine("Exercise 2 \n ");
            int[] num2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var averageOfOddNumbers = num2.Where(n => n % 2 == 1 || n % 2 == -1).Average();
            Console.WriteLine(averageOfOddNumbers);
            Console.WriteLine();
            var averageOfOddNumbersQuery = from n in num2
                                           where n % 2 == 1 || n % 2 == -1
                                           select n;
            Console.WriteLine(averageOfOddNumbersQuery.Average());
            Console.WriteLine();

            // Exercise 3
            Console.WriteLine("Exercise 3 \n ");
            int[] num3 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var squaredPositiveNumbers = num3.Where(n => n > 0).Select(n => n * n);
            squaredPositiveNumbers.ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine();
            var squaredPositiveNumbersQuery = from n in num3
                                              where n > 0
                                              select n * n;
            squaredPositiveNumbersQuery.ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine();

            // Exercise 4
            Console.WriteLine("Exercise 4 \n ");
            int[] num4 = new[] { 3, 9, 2, 8, 6, 5 };
            var squaredBiggerThan20 = num4.Where(n => n * n > 20);
            squaredBiggerThan20.ToList().ForEach(n => Console.WriteLine(n));
            var squaredBiggerThan20Query = from n in num4
                                           where n * n > 20
                                           select n;
            squaredBiggerThan20Query.ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine();

            // Exercise 5
            Console.WriteLine("Exercise 5 \n ");
            int[] num5 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var frequencyOfNumbers = num5.GroupBy(n => n);
            frequencyOfNumbers.ToList().ForEach(n => Console.WriteLine(n.Key + ": " + n.Count()));
            Console.WriteLine();

            // Exercise 6
            Console.WriteLine("Exercise 6 \n ");
            string str = "Write a LINQ Expression to find the frequency of characters in a given string.";
            var frequencyOfChars = str.Replace(" ", "").ToLower().GroupBy(n => n);
            frequencyOfChars.ToList().ForEach(n => Console.WriteLine(n.Key + ": " + n.Count()));
            Console.WriteLine();

            // Exercise 7
            Console.WriteLine("Exercise 6 \n ");
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        }


    }
}
