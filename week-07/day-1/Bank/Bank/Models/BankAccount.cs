using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class BankAccount
    {

        public string Name { get; }
        public double Balance { get; }
        public string Occupation { get; }
        public int Id { get; }
        public bool BadGuy { get; }

        public BankAccount(string name, double balance, string occupation, bool badGuy)
        {
            Name = name;
            Balance = balance;
            Occupation = occupation;
            BadGuy = badGuy;
        }

        public BankAccount()
        {

        }
    }
}
