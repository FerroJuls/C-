using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    public interface IRepositorio
    {
        void Guardar(string datos);
    }

    public class RepositorioSQL : IRepositorio
    {
        public void Guardar(string datos)
        {
            Console.WriteLine($"Datos guardados en SQL: {datos}");
        }
    }
}
