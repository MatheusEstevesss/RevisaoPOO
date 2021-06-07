using ExeEmpolyees.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExeEmpolyees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Enter the employee #{i+1}: ");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                if(outsourced == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, addCharge));
                } 
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }                
            }

            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
