using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    public class Paloma : IVolar, IComer
    {
        public void Comer()
        {
            Console.WriteLine("La paloma");
        }

        public void Volar()
        {
            Console.WriteLine("La paloma");
        }
    }
}
