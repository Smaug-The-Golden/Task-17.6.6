﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17._6._6
{
    public class SalaryAccount: IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        void IAccount.CalculatorInterest()
        {
        }
    }
}
