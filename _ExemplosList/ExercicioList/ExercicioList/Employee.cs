using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioList
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Id { get; set; }

        public Employee(string name, double salary, int id)
        {
            Name = name;
            Salary = salary;
            Id = id;
        }

        public void UpdateSalary(double percentage)
        {
            Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
