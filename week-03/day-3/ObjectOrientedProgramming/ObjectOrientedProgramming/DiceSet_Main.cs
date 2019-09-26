using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6
            DiceSet diceSet = new DiceSet();

            diceSet.Roll();
            Console.WriteLine("First roll: ");

            for (int i = 0; i < diceSet.GetCurrent().Length; i++)
            {
                if (i < diceSet.GetCurrent().Length - 1)
                {
                    Console.Write(diceSet.GetCurrent(i) + ", ");
                }
                else
                {
                    Console.Write(diceSet.GetCurrent(i));
                }
            }
            Console.WriteLine();

            //while (diceSet.GetCurrent(1) != 6 && diceSet.GetCurrent(2) != 6 && diceSet.GetCurrent(3) != 6
            //    && diceSet.GetCurrent(4) != 6 && diceSet.GetCurrent(5) != 6 && diceSet.GetCurrent(0) != 6)
            //{
            //    Console.WriteLine("Not a single 6, rerolling");
            //    diceSet.Reroll();
            //    for (int i = 0; i < diceSet.GetCurrent().Length; i++)
            //    {
            //        if (i < diceSet.GetCurrent().Length - 1)
            //        {
            //            Console.Write(diceSet.GetCurrent(i) + ", ");
            //        }
            //        else
            //        {
            //            Console.Write(diceSet.GetCurrent(i));
            //        }
            //    }
            //    Console.WriteLine();
            //}

            while (diceSet.GetCurrent(1) + diceSet.GetCurrent(2) + diceSet.GetCurrent(3) +
                diceSet.GetCurrent(4) + diceSet.GetCurrent(5) + diceSet.GetCurrent(0) < 36)
            {
                Console.WriteLine("Rerolling all the dices that are not 6");
                for (int i = 0; i < diceSet.GetCurrent().Length; i++)
                {
                    if (diceSet.GetCurrent(i) < 6)
                    {
                        diceSet.Reroll(i);
                    }

                    if (i < diceSet.GetCurrent().Length - 1)
                    {
                        Console.Write(diceSet.GetCurrent(i) + ", ");
                    }
                    else
                    {
                        Console.Write(diceSet.GetCurrent(i));
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("All dices are 6. Thank you for playing, have a wonderful day");
            Console.ReadKey();
        }
    }
}
