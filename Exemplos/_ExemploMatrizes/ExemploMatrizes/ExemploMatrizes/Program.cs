using System;

namespace ExemploMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            Console.Write("Tamanho da matrix: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{matrix[i,i]} ");
            }

            Console.WriteLine();
            Console.Write("Negative numbers = ");
            foreach (int item in matrix)
            {                
                if (item <= 0)
                    cont++;
            }

            Console.WriteLine(cont);
        }
    }
}
