using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5Practica
{
    public class Empleado : Persona, ICalcularSalario
    {
        public int SalarioPorDias { get; set; }
        public string Cargo { get; set; }
        public int DiasTrabajados { get; set; }

        public Empleado() : base()
        {
            Cargo = "Empleado";
            SalarioPorDias = 43334;
            DiasTrabajados = 30;
        }

        public decimal CalcularSalario()
        {
            return SalarioPorDias * DiasTrabajados;
        }

        public override void MostrarPersona()
        {
            Console.WriteLine($"{Cargo}");
            Console.WriteLine();
            base.MostrarPersona();
            decimal Salario = CalcularSalario();
            Console.WriteLine($"Salario: {Salario}");
        }
    }

}
