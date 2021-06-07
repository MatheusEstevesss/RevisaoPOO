using System;
using System.Collections.Generic;
using System.Text;

namespace UpDownCasting.Entities
{
    class SavingAccounts : Account
    {
        public double InterestRate { get; set; }

        public SavingAccounts()
        {

        }

        public SavingAccounts(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {            
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) //usa-se a palavra override para fazer um sobreposição
        {
            base.Withdraw(amount); // executa o método conforme a lógica implementada na superclasse
            Balance -= 2; // neste caso irá descontar o valor de 5 passado na superclasse e também esse valor de 2, totalizando 7
        }
    }
}
