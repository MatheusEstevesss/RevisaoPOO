using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AutoProperties
{
    class Produto
    {
        private string _nome; //nao fazemos o AutoProp pois o nome possui uma lógica particular do nosso programa
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }//Exemplo de auto propertie, faz a mesma coisa que a forma antiga porem de uma maneira resumida ATALHO prop para formar isso mais rápido

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        //Exemplo Properties - Agora isso nos possibilita que no programa principal nós simplemente coloquemos p.Nome (como c fosse um atributo) 
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;//Este value substitui o parâmetro que estaria sendo criado no método Set
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AddProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoveProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
