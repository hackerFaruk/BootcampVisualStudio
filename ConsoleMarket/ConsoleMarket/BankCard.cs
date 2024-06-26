﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    public class BankCard : AccountBase
    {

        public Bank ConnnectedBank { get; private set; }
        public BankAccount ConnectedBankAccount { get;  private set; }
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



        public bool PaymentRequest( double price)
        {
            bool paymnetResult = this.ConnnectedBank.PaymentRequest(this, price);
            return paymnetResult;
        }

        // below will be deleted 
        public bool CardVerificationRequest()
        {
            // first create code
            if (this.ConnnectedBank.CardVerificationHandler(this)) { return true; }
            else { return false; };

        }

        private bool MakePayment(double Amount)
        {
            if( this.ConnnectedBank.isEnoughCredit(Amount, this) == true)
            {
                
                return true;
            }
            else { return false; };

        }
        
    }
}
