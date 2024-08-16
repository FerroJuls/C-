using System;
using System.Threading.Tasks;
using _1_5Practica;

namespace ConsoleApp
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var datos = await TraerPersona();
            Console.WriteLine(datos);

            Console.ReadKey();
        }

        static async Task<string> TraerPersona()
        {
            Console.Write("Ingresar Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresar Edad: ");
            if (!int.TryParse(Console.ReadLine(), out int edad))
            {
                return "Favor ingrese numeros.";
            }

            Console.Write("Ingresar Direccion: ");
            string direccion = Console.ReadLine();


            Console.Write("Ingresar Teléfono: ");
            if (!uint.TryParse(Console.ReadLine(), out uint telefono))
            {
                return "Favor ingrese numeros.";
            }


            Console.Write("Ingresar Cargo: ");
            string cargo = Console.ReadLine();

            Console.Write("Ingresar días trabajados: ");
            if (!int.TryParse(Console.ReadLine(), out int diasTrabajados))
            {
                return "Valor inválido para los días trabajados.";
            }

            Empleado empleado = new Empleado(nombre, edad, telefono, direccion, cargo, 1300000 / 30);

            empleado.EstablecerDiasTrabajados(diasTrabajados);
            Console.WriteLine();

            Console.WriteLine("Generando Ficha Laboral, por favor espere...");
            await Task.Delay(5000); 

            empleado.MostrarPersona();

            Console.WriteLine();

            return "Ficha Laboral Terminada";
        }
    }
}
