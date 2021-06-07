using System;

namespace Ex1_Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas x, y;
            x = new Pessoas();
            y = new Pessoas();

            Console.WriteLine("Digite a primeira pessoa:");
            x.Nome = Console.ReadLine();
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda pessoa: ");
            y.Nome = Console.ReadLine();
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade > y.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {x.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {y.Nome}");
            }
        }
    }
}
