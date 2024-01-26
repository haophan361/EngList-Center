using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CurrentAccount:IBankAccount
    {
        private decimal balance;
        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public void DisplayBalance()
        {
            Console.WriteLine("Current Account Balance "+balance);
        }
    }
}
