using System;
using System.Globalization;

namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios x, y;
            x = new Funcionarios();
            y = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário: ");
            x.Nome = Console.ReadLine();
            x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            y.Nome = Console.ReadLine();
            y.Salario = double.Parse(Console.ReadLine());

            double media = (x.Salario + y.Salario) / 2;
            Console.WriteLine($"Salário médio = {media}");
        }
    }
}
