using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_EP.Entidades
{
    public class Pedido
    {
        public int CodigoPedido { get; set; }
        public int CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public string Cliente { get; set; }

        public Pedido()
        {
        }

        public Pedido(int codigoPedido, int codigoProducto, string descripcion, int cantidad, decimal precio, decimal total)
        {
            CodigoPedido = codigoPedido;
            CodigoProducto = codigoProducto;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;
        }
    }
}
