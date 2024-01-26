using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BankApp
    {
        public static void Main(string[] args)
        {
            IBankAccount savings = BankAccountFactory.CreateBankAccount("savings");
            savings.Deposit(1500);
            savings.DisplayBalance();
            IBankAccount current = BankAccountFactory.CreateBankAccount("current");
            current.Deposit(1000);
            current.DisplayBalance();
        }
    }
}
