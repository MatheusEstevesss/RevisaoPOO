using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioBanco
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int numeroConta)
        {
            Titular = nome;
            NumeroConta = numeroConta;
        }

        public ContaBancaria(string nome, int numeroConta, double depositoInicial) : this(nome, numeroConta)
        {
            Deposito(depositoInicial);
        }
        
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo = Saldo - valor - 5.00;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
