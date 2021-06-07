using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass.Entities
{
    abstract class Account
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

        public virtual void Withdraw(double amount) //Usa-se a palavra virtual para indicar que o método pode ser sobreposto nas subclasses
        {
            Balance -= amount + 5;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
