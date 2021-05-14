using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioSalario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double Salarioliquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Salarioliquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
