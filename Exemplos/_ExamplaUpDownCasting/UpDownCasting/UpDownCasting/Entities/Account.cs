using System;
using System.Collections.Generic;
using System.Text;

namespace UpDownCasting.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string  Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
    }
}
