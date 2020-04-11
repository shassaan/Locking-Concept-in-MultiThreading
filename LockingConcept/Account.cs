using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockingConcept
{
    class Account
    {
        private double Balance { get; set; }

        public Account(double d)
        {
            Balance = d;
        }

        public void Deposit(double d)
        {
            
            lock (this)
            {
                var temp = Balance;
                temp += d;
                Balance = temp;
                Balance -= (0.1 * d);
            }
                
            
        }

        public double Inquire()
        {
            return Balance;
        }
    }
}
