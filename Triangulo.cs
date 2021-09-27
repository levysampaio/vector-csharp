using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCShrap
{
    class Triangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2.0;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return "Area: " + Area().ToString("F2", CultureInfo.InvariantCulture) + "| Perimetro: " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + " | Diagonal: " + Diagonal().ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
