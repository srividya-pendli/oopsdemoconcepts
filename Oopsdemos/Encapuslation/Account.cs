using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsdemos.Encapuslation
{
    class Account
    {
        public double balance = 20000;
        public void setBalance(double amount)
        {
            if (amount > 100)
            {
                balance = balance + amount;
            }
            else
                Console.WriteLine("please enter minimum balance as 100 or above");
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
