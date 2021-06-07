using System;
using UpDownCasting.Entities;

namespace UpDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            //UPCASTING = Conversão da subclasse para a Superclasse

            Account acc1 = bacc; //conversão é permitida, pois o BusinessAccount é um acount (por causa da herança)
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);
            Account acc3 = new SavingAccounts(1004, "Anna", 0, 0.01);

            //DOWNCASTING = Da superclasee para a subclasse

            //BusinessAccount acc4 = acc2; para o compilador acc2 é do tipo account, precisa especificar que vai ter um objeto do tipo BusinessAccount, para isso precisamos fazer um casting

            BusinessAccount acc4 = (BusinessAccount)acc2;

            acc4.Loan(100);

            //Account acc5 = (BusinessAccount)acc3; Deste jeito apresentará um erro apenas em tempo de exucação, pois SavingAccounts é diferente de BusinessAccount, para mostrar isso antes usa-se "is"

            //Este if irá falhar pois acc3 não é uma instancia de BusinessAccount
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; //Sintaxe alternativa para fazer o casting

                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingAccounts)
            {
                SavingAccounts acc5 = (SavingAccounts)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
