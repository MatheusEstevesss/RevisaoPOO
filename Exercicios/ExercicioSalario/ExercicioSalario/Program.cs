using System;
using System.Globalization;

namespace ExercicioSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {func}");

            Console.Write("Digite a porcentar para aumentar o salário: ");
            double ptc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            func.AumentarSalario(ptc);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {func}");
        }
    }
}
