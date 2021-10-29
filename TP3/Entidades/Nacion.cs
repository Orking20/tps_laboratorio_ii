using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Nacion
    {
        private static int id;
        private string nombre;

        public Nacion(int idNacion, string nombre)
        {
            Id = idNacion;
            this.Nombre = nombre;
        }

        public static int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
    }
}
