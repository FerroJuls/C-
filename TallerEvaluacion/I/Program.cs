namespace ConsoleApp
{
    using D;
    using System;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    class Program
    {
        static void Main()
        {
            // crea animales
            IComer perro = new Perro();
            IComer pato = new Pato();
            IComer paloma = new Paloma();

            IVolar patoVolar = new Pato();
            IVolar palomaVolar = new Paloma();

            INadar perroNadar = new Perro();
            INadar patoNadar = new Pato();

            // muestra que hace el perro,pato,palomo

            Console.WriteLine("Animales que pueden comer");
            perro.Comer();
            pato.Comer();
            paloma.Comer();

            Console.WriteLine();

            Console.WriteLine("Animales que pueden volar");
            patoVolar.Volar();
            palomaVolar.Volar();

            Console.WriteLine();

            Console.WriteLine("Animales que pueden Nadar");
            perroNadar.Nadar();
            patoNadar.Nadar();
        }
    }

}