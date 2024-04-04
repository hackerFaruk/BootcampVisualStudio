﻿using System;
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
        private int BankId;

        List<BankCard> bankCards = new List<BankCard>();

        public Bank(string name)
        {
            this.Name = name;
            this.BankId = rnd.Next(10000, 10000);
        }

        /// <summary>
        /// This account opener that only uses positive credit
        /// </summary>
        /// <param name="person"></param>
        /// <param name="credit"></param>
        public void openAccount(Person person, double credit)
        {
            int bankId = this.BankId;
            if (credit < 0)
            {
                return;
            }
            else if (BankAccounts.Keys.Contains(person.TCKN))
            {
                BankAccounts[person.TCKN].UpdateCredit(credit, bankId);
                return;
            }
            BankAccount account = new BankAccount(person, credit, BankId);
            BankAccounts.Add(person.TCKN, account);
        }

        /// <summary>
        /// This is an updater that can reduce bank acount credit
        /// </summary>
        /// <param name="person"></param>
        /// <param name="credit"></param>
        public void updateCredit(Person person, double credit)
        {
            int bankId = this.BankId;
            if (BankAccounts.Keys.Contains(person.TCKN))
            {
                BankAccounts[person.TCKN].UpdateCredit(credit, bankId);
            }
        }


        public BankCard CreateBankCard(Person person , BankAccount? account)
        {
            int bankId = this.BankId;
            if (account == null) { account = BankAccounts[person.TCKN]; }
            return new BankCard(person, this , account,bankId );
        }


    }
}
