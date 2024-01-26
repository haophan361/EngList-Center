using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class BankAccountFactory
    {
        public static IBankAccount CreateBankAccount(string accountType)
        {
            IBankAccount account = null;
            switch (accountType)
            {
                case "savings" :
                {
                        account = new SavingAccount();
                        break;
                }
                case "current":
                {
                    account=new CurrentAccount(); 
                    break;
                }
                default:
                {
                    throw new ArgumentException("Invalid AccountType", nameof(accountType));
                }
            }
            return account;
        }
    }
}
