using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_EP.Entidades
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Clave { get; set; }

        public Usuario()
        {
        }

        public Usuario(int codigo, string nombre, int clave)
        {
            Codigo = codigo;
            Nombre = nombre;
            Clave = clave;
        }
    }
}
