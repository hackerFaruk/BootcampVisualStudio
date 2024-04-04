using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    public class BankCard : AccountBase
    {
        
        Bank ConnnectedBank;
        BankAccount ConnectedBankAccount;
        private int bankPortectorId; // while cretaing bank bank will have random int and only bank will know it account credit only can be changed by bank 


        /// <summary>
        /// Can only be used by a bank because of bankprotector id
        /// connects person and bank and bank account 
        /// should be registered to bank account so can make payment from there
        /// </summary>
        /// <param name="accountOwner"></param>
        /// <param name="bank"></param>
        /// <param name="account"></param>
        /// <param name="bankPortectorId"></param>
        public BankCard(Person accountOwner, Bank bank, BankAccount account, int bankPortectorId) : base(accountOwner)  
        {
            
            this.ConnnectedBank = bank;
            this.ConnectedBankAccount = account;
            this.bankPortectorId= bankPortectorId;


        }

        
    }
}
