using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrueba
{
    internal class producto
    {
        private int idProducto { get; set; }
        private string nombreProducto { get; set; }
        private decimal precioProducto { get; set; }
        private string descripcionProducto { get; set; }

        // Relación con la categoría
        private categoria categoria { get; set; } 

        public producto(int idProducto, string nombreProducto, decimal precioProducto, string descripcionProducto, categoria categoria)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.descripcionProducto = descripcionProducto;
            this.categoria = categoria;
        }

        public override string ToString()
        {
            return $"Producto: {nombreProducto}, Descripción: {descripcionProducto}, Categoría: {categoria}";
        }
    }
}


