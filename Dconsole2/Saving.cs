﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dconsole2
{
    public class SavingAccount:BankAccount
    {


        public decimal InterestRate { get; private set; }
        public SavingAccount(int ac,string ach,decimal bal,decimal ir) : base(ac, ach, bal)
        {
            InterestRate = ir;

        }

        public void ApplyInt(decimal rate)
        {
            decimal p_bal = Balance;
            Balance += (Balance*(rate/100));

            Console.WriteLine($"Your previous balance was {p_bal} applying interest rate {InterestRate} current balance is {Balance}");

        }

        
    }
}
