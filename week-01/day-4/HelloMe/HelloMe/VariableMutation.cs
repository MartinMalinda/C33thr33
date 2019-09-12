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
            int a = 3;
            // make it bigger by 10
            a += 10;
            Console.WriteLine(a);

            int b = 100;
            // make it smaller by 7
            b -= 7;
            Console.WriteLine(b);

            int c = 44;
            // please double c's value
            c *= 2;
            Console.WriteLine(c);

            int d = 125;
            // please divide by 5 d's value
            d /= 5;
            Console.WriteLine(d);

            int e = 8;
            // please cube of e's value
            e *= e * e;
            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)
            bool compare1;
            if (f1 > f2)
            {
                compare1 = true;
              
            }
            else
            {
                compare1 = false;
            }
            Console.WriteLine(compare1);
            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            bool compare2;
            if (g2*2 > g1)
            {
                compare2 = true;
            }
            else
            {
                compare2 = false;
            }
            Console.WriteLine(compare2);
            long h = 1357988018575474;
            // tell if 11 is a divisor of h (print as a boolean)
            bool dvisor1;
            if ((h%11)>0)
            {
                dvisor1 = false;
            }
            else
            {
                dvisor1 = true;
            }
            Console.WriteLine(dvisor1);
            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            bool compare3;
            if (i1 > (i2 * i2) && i1 < (i2 * i2 * i2))
            {
                compare3 = true;
            }
            else compare3 = false;
            
            Console.WriteLine(compare3);
            int j = 1521;
            // tell if j is divisible by 3 or 5 (print as a boolean)
            bool divisible;
            if ((j%3)<1 || (j%5)<1)
            {
                divisible = true;
            }
            else
            {
                divisible = false;
            }
            Console.WriteLine(divisible);
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
