namespace ConsoleApp
{
    using OAbiertoCerrado;
    using System;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    class Program
    {
        static void Main()
        {
            Figura cuadrado = new Cuadrado(5);
            Figura circulo = new Circulo(3);

            Console.WriteLine($"Area del cuadrado: {cuadrado.CalcularArea()}");
            Console.WriteLine($"Area del cIrculo: {circulo.CalcularArea()}");
        }
    }
}