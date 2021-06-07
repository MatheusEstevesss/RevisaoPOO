using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDollar
{
    class ConversorMoeda
    {
        public static double Iof = 6.0;

        public static double Conversor(double cotacao, double valor)
        {
            double total = valor * cotacao;
            return total + (total * Iof / 100);
        }
    }
}
