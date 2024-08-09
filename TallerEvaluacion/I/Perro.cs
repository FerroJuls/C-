using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    public class Perro : IComer, INadar
    {
        public void Comer()
        {
            Console.WriteLine("El perro");
        }

        public void Nadar()
        {
            Console.WriteLine("El perro");
        }
    }
}
