using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C; //nome de classe e atributor começa com letra maiúscula

        public double Area() //não precisa passar parâmetros pois o metodo está dentro da classe
        {
            double p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            
        }

    }
}
