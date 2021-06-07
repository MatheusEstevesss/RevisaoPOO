using System;
using System.Collections.Generic;
using System.Text;

namespace ExeTaxes.Entities
{
    class PhysicalPerson : Person
    {
        public double HealthExpenses { get; set; }

        public PhysicalPerson(string name, double incomeYear, double healthExpenses) : base(name, incomeYear)
        {
            HealthExpenses = healthExpenses;
        }
        public override double Taxes()
        {
            if ( IncomeYear <= 20000 )
            {
                if (HealthExpenses > 0)
                {
                    return IncomeYear * 0.15 - HealthExpenses * 0.5;
                } 
                else
                {
                    return IncomeYear = IncomeYear * 0.15;
                }
            }
            else
            {
                if ( HealthExpenses > 0 )
                {
                    return IncomeYear * 0.25 - HealthExpenses * 0.5;
                }
                else
                {
                    return IncomeYear += IncomeYear * 0.25;
                }
            }
        }
    }
}
