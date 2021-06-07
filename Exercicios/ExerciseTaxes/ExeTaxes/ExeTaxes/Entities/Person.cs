using System;
using System.Collections.Generic;
using System.Text;

namespace ExeTaxes.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double IncomeYear { get; set; }

        public Person(string name, double incomeYear)
        {
            Name = name;
            IncomeYear = incomeYear;
        }

        public abstract double Taxes();
    }
}
