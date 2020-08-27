using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro
{
    public class Indice
    {
        public List<Letra> Lecciones { get; set; }

        public string Leer { get; set; }

        public Indice()
        {
            this.Lecciones = new List<Letra>();

            Letra letraA = new Letra();
            letraA.Codigo = "A";
            letraA.Lectura = "A - A - A    Avion";
            letraA.Cantidad = 1;

            Letra letraE = new Letra();
            letraE.Codigo = "E";
            letraE.Lectura = "E - E - E    Elefante";
            letraE.Cantidad = 1;

            Letra letraI = new Letra();
            letraI.Codigo = "I";
            letraI.Lectura = "I - I - I    Iglesia";
            letraI.Cantidad = 1;

            Letra letraO = new Letra();
            letraO.Codigo = "O";
            letraO.Lectura = "O - O - O    Oso";
            letraO.Cantidad = 1;

            Letra letraU = new Letra();
            letraU.Codigo = "U";
            letraU.Lectura = "U - U - U    Uva";
            letraU.Cantidad = 1;

            this.Lecciones.Add(letraA);
            this.Lecciones.Add(letraE);
            this.Lecciones.Add(letraI);
            this.Lecciones.Add(letraO);
            this.Lecciones.Add(letraU);
        }

        public int validaLetra(string codigo)
        {
            int encontro = -1;

            for (int i = 0; i<this.Lecciones.Count; i++)
            {
                if (this.Lecciones[i].Codigo == codigo)
                {
                    encontro = i;
                }
            }

            return encontro;
        }

        public bool agregarLetra(Letra letra)
        {
            int enc = this.validaLetra(letra.Codigo);
            if (enc >= 0)
            {
                this.Lecciones[enc].sumarCantidad(letra.Cantidad);
            }
            else
            {
                this.Lecciones.Add(letra);
            }
            return true;
        }

        public bool eliminarLetra(string codigo)
        {
            int enc = this.validaLetra(codigo);
            
            if(enc >= 0)
            {
                this.Lecciones.RemoveAt(enc);
                return true;
            }

            return false;
        }


        public Letra leyendo(string codigo)
        {
            int enc = this.validaLetra(codigo);
            if (enc >= 0)
            {
                if (this.Lecciones[enc].validarCantidad())
                {
                    return this.Lecciones[enc];
                }
            }
            return null;
        }

        public string listadoLecciones()
        {
            string lista = "";
            foreach(Letra item in this.Lecciones)
            {
                lista += item.Codigo + " " + "\n";
            }
            return lista;
        }

    }
}
