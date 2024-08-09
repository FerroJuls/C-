using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    public class Pato : IComer, INadar, IVolar
    {
        public void Comer()
        {
            Console.WriteLine("El pato");
        }

        public void Volar()
        {
            Console.WriteLine("El pato");
        }

        public void Nadar()
        {
            Console.WriteLine("El pato");
        }
    }
}

