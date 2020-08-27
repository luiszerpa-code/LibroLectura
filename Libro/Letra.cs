using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro
{
    public class Letra
    {
        public string Codigo { get; set; }
        public string Lectura { get; set; }
        public int Cantidad { get; set; }

        public void sumarCantidad(int cantidad)
        {
            this.Cantidad += cantidad;
        }

        public bool validarCantidad()
        {
            if(this.Cantidad > 0)
            {
                return true;
            }
            return false;
        }
    }
}
