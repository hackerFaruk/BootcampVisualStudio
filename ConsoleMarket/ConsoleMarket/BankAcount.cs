using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    public class BankAccount : AccountBase
    {

        public double AccountCredit { get; private set; }
        private int bankPortectorId; // while cretaing bank bank will have random int and only bank will know it account credit only can be changed by bank 

        public BankAccount(Person accountOwner, double accountCredit, int bankPortectorId) : base(accountOwner)
        {
            this.AccountCredit = accountCredit;
            this.bankPortectorId = bankPortectorId;
        }

        public void UpdateCredit(double credit, int bankID) {
        if (bankID == bankPortectorId) { AccountCredit += credit; }
        }

    }
}
