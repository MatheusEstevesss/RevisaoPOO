using ExercicioEnum.Entities.Enums;
using System.Collections.Generic;

namespace ExercicioEnum.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }// Composição de objetos, funciona como c fosse uma FK
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Um trabalhador possui vários contratos, para representarmos o "vários" criamos uma lista de contratos

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract); //Chamamos a lista de contratros e passamos que ele irá adicionar a essa lista o parâmetro do nosso método
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract); //Chamamos a lista de contratros e passamos que ele irá remover a essa lista o parâmetro do nosso método
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
