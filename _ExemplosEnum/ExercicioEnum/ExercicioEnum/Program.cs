using ExercicioEnum.Entities;
using ExercicioEnum.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string depName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junio/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Department dep = new Department(depName);
            Worker worker = new Worker(name, level, salary, dep);

            Console.Write("How many contracts to this worker: ");
            int contracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < contracts; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date: (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valueHour, hours);

                worker.AddContract(contract);//Adicionando o contrato que acabou de ser instanciado no trabalhador
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate the income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2)); //estamos usando a funçao substring para recortar a string original na posição 0 até a 2 (0 é o indice como c fosse um array)
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month)}");
        }
    }
}
