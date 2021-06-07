using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> listEmployees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i+1}");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listEmployees.Add(new Employee(name, salary, id));
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary incresase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = listEmployees.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine());
                emp.UpdateSalary(percent);
            }
            else
            {
                Console.WriteLine("This id doesn't exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee item in listEmployees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
