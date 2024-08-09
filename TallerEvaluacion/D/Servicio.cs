using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    public class Servicio
    {
        private readonly IRepositorio _repositorio;

        public Servicio(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void ProcesarDatos(string datos)
        {
            _repositorio.Guardar(datos);
        }
    }
}
