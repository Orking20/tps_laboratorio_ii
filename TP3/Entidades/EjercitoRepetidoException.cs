using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EjercitoRepetidoException : Exception
    {
        private Exception excepcion;

        public EjercitoRepetidoException(string mensaje) : this(mensaje, null)
        {
            
        }

        public EjercitoRepetidoException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
