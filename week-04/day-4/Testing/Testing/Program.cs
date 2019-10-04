using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Apple
    {
        public Apple()
        {

        }
        public string GetApple()
        {
            return "Apple";
        }
    }

    public class Sum
    {
        public static int SumItUp(List<int> x)
        {
            int sum = 0;
            for (int i = 0; i < x.Count; i++)
            {
                sum = sum + x[i];
            }
            return sum;
        }
    }

    public class Program
    {
        public static List<int> emptyList = new List<int>();
        static void Main(string[] args)
        {
            Apple Okamura = new Apple();
            Console.WriteLine(Okamura.GetApple());

        }
    }
}
