using System;
using System.Globalization;

namespace ProdutosOtimizado
{
    class Program
    {
        static void Main(string[] args)
        {          

            Console.WriteLine("Entre os dados do produto");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, 5);

            Console.WriteLine($"Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qtd = int.Parse(Console.ReadLine());

            p.AddProdutos(qtd);

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());

            p.RemoveProdutos(qtd);

            Console.WriteLine("Dados atualizados: " + p);         
            
        }
    }
}
