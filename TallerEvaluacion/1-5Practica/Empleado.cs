using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5Practica
{
    public class Empleado : Persona, ICalcularSalario
    {
        public decimal SalarioPorDias { get; set; }
        public string Cargo { get; set; }
        public int DiasTrabajados { get; set; }

        public Empleado(string nombre, int edad, uint telefono, string direccion, string cargo, decimal salarioPorDias)
            : base(nombre, edad, telefono, direccion)
        {
            Cargo = cargo;
            SalarioPorDias = salarioPorDias;
        }

        public decimal CalcularSalario()
        {
            return SalarioPorDias * DiasTrabajados;
        }

        public override void MostrarPersona()
        {
            Console.WriteLine();
            Console.WriteLine(new string('=', 30));
            Console.WriteLine($" Cargo: {Cargo,-30}");
            Console.WriteLine(new string('=', 30)); 

            base.MostrarPersona(); 

            Console.WriteLine(new string('=', 30));
            decimal salario = CalcularSalario();
            Console.WriteLine($" Salario: {salario:C2}");
            Console.WriteLine(new string('=', 30));  
            Console.WriteLine(); 
        }


        public void EstablecerDiasTrabajados(int dias)
        {
            DiasTrabajados = dias;
        }
    }
}