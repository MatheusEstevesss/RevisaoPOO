using System;
using System.Collections.Generic;

namespace ExemploList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Matheus");//add adicona por padrão no final da lista
            list.Add("Alex");
            list.Add("Ana");
            list.Insert(2, "Marco");//insert você pode passar em qual posição será adicionado

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');// resposável por retornar o primeiro nome que começa com A maiúculo "Expressão lambda"
            Console.WriteLine($"Primeiro nome que começa com A: {s1}");

            string s2 = list.FindLast(x => x[0] == 'A');// retorna o útlimo nome que começa com a letra A
            Console.WriteLine($"Último nome que começa com A: {s2}");

            int p1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First index with A: {p1}");

            int p2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last index with A: {p2}");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------------------------------\n");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("------------------------------------\n");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            /*
            list.RemoveRange(1, 2); // primeiro posição depois a quantidade de elementos que iremos deletar
            Console.WriteLine("------------------------------------\n");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }           

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("------------------------------------\n");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(0);//a lista ficará fazia e tem que ser o número 0 pois só sobrou 1 pessoa nesta lista e o primeiro index é 0
            Console.WriteLine("------------------------------------\n");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }*/
        }
    }
}
