using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Pueblo<T>
    {
        private static int idEstatico;
        private int id;
        private T nacion;

        public Pueblo()
        {

        }

        public Pueblo(int idEstatico, T nacion)
        {
            this.id = idEstatico;
            this.nacion = nacion;
        }

        public static int IdEstatico
        {
            get
            {
                return idEstatico;
            }
            set
            {
                idEstatico = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public T Nacion
        {
            get
            {
                return this.nacion;
            }
            set
            {
                this.nacion = value;
            }
        }
    }
}
