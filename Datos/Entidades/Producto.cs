using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_EP.Entidades
{
    public class Producto
    {
        public int CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencias { get; set; }

        public Producto()
        {
        }

        public Producto(int codigoProducto, string descripcion, decimal precio, int existencias)
        {
            CodigoProducto = codigoProducto;
            Descripcion = descripcion;
            Precio = precio;
            Existencias = existencias;
        }
    }
}
