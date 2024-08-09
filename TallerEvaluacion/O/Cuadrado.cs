using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAbiertoCerrado
{
    public class Cuadrado : Figura
    {
        public double Lado { get; set; }
        public Cuadrado(double lado)
        {
            Lado = lado;
        }
        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
