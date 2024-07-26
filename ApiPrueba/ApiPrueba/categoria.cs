using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrueba
{
    internal class categoria
    {
        private int idCategoria { get; set; }
        private string nombreCategoria { get; set; }
        private string descripcionCategoria { get; set; }

        public categoria(int idCategoria, string nombreCategoria, string descripcionCategoria)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
            this.descripcionCategoria = descripcionCategoria;
        }

        //Hace que devuelva nombre y descripcion
        public override string ToString()
        {
            return $"Categoria: {nombreCategoria}, Descripción: {descripcionCategoria}";
        }
    }
}
