using System;
using System.Globalization;

namespace ExercicioDollar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago {ConversorMoeda.Conversor(cotacao, valor).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
