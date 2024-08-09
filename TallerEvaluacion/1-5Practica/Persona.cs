using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5Practica
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        public Persona()
        {
            Nombre = "Julian";
            Edad = 18;
            Direccion = "cr 3 d 44 ";
        }

        public virtual void MostrarPersona()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Direccion: {Direccion}");
        }
    }
}

