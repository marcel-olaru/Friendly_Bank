using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friendly_Bank
{


    class Program
    {
        static void Main(string[] args)
        {
            Account PompisAccount = new Account();
            PompisAccount.Name = "Pompi";
            PompisAccount.State = AccountState.Active;
            PompisAccount.Balance = 100000;

            PrintAccount( PompisAccount);

            Account Temp;
            Temp = PompisAccount;
            Temp.Name = "Jim";
            Console.WriteLine(PompisAccount.Name);
        }

       internal enum AccountState

        {
            New,
            Active,
            UnderAudit,
            Frozen,
            Closed
        }

        internal struct Account

        {
            public AccountState State;
            public string Name;
            public string Address;
            public int AccountNumber;
            public int Balance;
            public int Overdraft;
        }

         static void PrintAccount (Account a)

        {
            Console.WriteLine("State of account: " + a.State);
            Console.WriteLine("Name: " + a.Name);
            Console.WriteLine("Address: " + a.Address);
            Console.WriteLine("AccountNumber:" + a.AccountNumber);
            Console.WriteLine("Balance: " + a.Balance);
            Console.WriteLine("Overdraft: " + a.Overdraft);
        }


    }
}
    
    
    

