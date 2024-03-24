using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    public class Bank
    {
        public string Name { get; private set; }

        public Dictionary<string, BankAccount> BankAccounts { get; private set; }

        Random rnd = new Random(); 
       private int BankId  ; 
        

        public Bank(string name)
        {
            this.Name = name;
            this.BankId = rnd.Next(10000, 10000);
        }

        public void openAccount(Person person, double credit)
        {
            if(credit < 0) { return; }
            else if(BankAccounts.Keys.Contains(person.TCKN)) { return; }
            BankAccount account = new BankAccount(person, credit, BankId);
            BankAccounts.Add(person.TCKN, account);
        }
    }

   
}
