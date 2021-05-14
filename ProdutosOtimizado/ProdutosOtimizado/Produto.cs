using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProdutosOtimizado
{
    class Produto
    {
        //Utilizando o Encapsulamento para que nao exponha para outro arquivo oq queremos. neste caso modiciares a Quantidade, para que o programador não possa mudar este valor a qualquer momento
        //Iremos "desabilitar" a opção de p.Quantidade = 10. Para que a quantidade possa ser alterada apenas através dos métodos que definimos nessa classe (AddProdutos, RemoveProdutos)
        public string Nome;
        public double Preco;
        private int _quantidade;
        //Private = Garante que esse atributo não poderá ser acessado por outra classe além da que o atributo foi criado (não poderá ser alterado fora desta classe)
        //Quando formor trabalhar com um atributo private adotamos outro método para nomea-los, comecando com _ e o seu nome será com letra minuscula ex: _quantidade

        //Criação de um construtor, o nome do contrutor deve ter o mesmo nome da classe
        public Produto(string nome, double preco, int quantidade) //estamos dizendo que na hora de instanciarmos um produto precisamos passar todos esses parâmetros
        {
            this.Nome = nome; //a palavra this serve para indicar ao programa que este Nome pertence ao atributo da classe e não a variavel local
            this.Preco = preco;
            this._quantidade = quantidade;
        }

        //Criação de outro construtor para exemplificar o conceito de Sobrecarga.
        public Produto(string nome, double preco)//Neste caso queremos passar somente o nome e o preco, adicionando como padrão o valor 0 a Quantidade. O valor 0 vem como default então não precisamos colocar Quantidade = 0;
        {
            Nome = nome;
            Preco = preco;
        }

        public int GetQuantidade() //como o atributo está como private, não poderíamos nem mostrar na tela o valor deste atributo, para isso usa-se o "Get;Set;" para podermos mostrar esse valor ao usuário
        {
            //Neste caso como estamos criando o método Get queremos apenas pegar o valor desta váriavel e mostrar na tela, MAS AINDA É IMPOSSIBILITADO DE ALTERAR ESTE ATRIBUTO POIS NÃO TEMOS O "SET"
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            //Neste caso tornamos possível alterar o valor do atributo quantidade fora da classe em que ele foi criado. ESTE É O MÉTODO "SET"
            _quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * _quantidade;
        }

        public void AddProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoveProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
