using ExeTaxes.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExeTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if ( ch == 'i' )
                {
                    Console.Write("Health expenditures: ");
                    double healthExpanditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listPerson.Add(new PhysicalPerson(name, income, healthExpanditures));
                } 
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    listPerson.Add(new LegalPerson(name, income, numberEmployees));
                }
            }

            double sum = 0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (Person person in listPerson)
            {
                double taxPerson = person.Taxes();
                Console.WriteLine($"{person.Name}: $ {taxPerson.ToString("F2", CultureInfo.InvariantCulture)}");
                sum += taxPerson;
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL PAXES: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
