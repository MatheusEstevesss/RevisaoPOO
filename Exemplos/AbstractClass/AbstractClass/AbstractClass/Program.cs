using System;
using System.Collections.Generic;
using AbstractClass.Entities;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingAccounts(1001, "Alex", 500, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500, 400));
            list.Add(new SavingAccounts(1003, "Bob", 500, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500, 500));

            double sum = 0;

            //Caso a superclasse account não existise, não poderíamos ter essa lista com tipos diferentes, tornando esse cálculo ainda mais dificil de ser executado
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine(sum);

            //Aqui nos aproveitamos do polimorfismo para realizar o método Withdraw em cada conta
            foreach (Account acc in list)
            {
                acc.Withdraw(10);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine(acc.Balance);
            }
        }
    }
}
