using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17._6._6
{
    class NormalAccount : IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public void CalculatorInterest()
        {
            Interest = Balance * 0.4;
            if (Balance < 1000) Interest -= Balance * 0.2;
            else if (Balance < 50000) Interest -= Balance * 0.4;
        }
    }
}
