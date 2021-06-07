using System;
using System.Collections.Generic;
using System.Text;

namespace ExeTaxes.Entities
{
    class LegalPerson : Person
    {
        public int NumberEmployees { get; set; }

        public LegalPerson(string name, double incomeYear, int numberEmployees) : base(name, incomeYear)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Taxes()
        {
            if( NumberEmployees <= 10 )
            {
                return IncomeYear = IncomeYear * 0.16;
            } 
            else
            {
                return IncomeYear = IncomeYear * 0.14;
            }
        }
    }
}
