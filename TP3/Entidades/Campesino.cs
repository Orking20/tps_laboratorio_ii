using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Campesino : Pueblo<ENacion>
    {
        private string profesion;

        public Campesino(int id, ENacion nacion, string profesion) : base(id, nacion)
        {
            this.profesion = profesion;
        }

        public string Profesion
        {
            get
            {
                return this.profesion;
            }
            set
            {
                this.profesion = value;
            }
        }
    }
}
