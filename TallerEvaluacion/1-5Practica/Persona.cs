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
        public uint Telefono { get; set; }
        public string Direccion { get; set; }

        public Persona(string nombre, int edad, uint telefono, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            Direccion = direccion;
        }

        public virtual void MostrarPersona()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Telefono: {Telefono}");
            Console.WriteLine($"Direccion: {Direccion}");
        }
    }
}

