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

        /// <summary>
        /// Inicializa los datos de un campesino
        /// </summary>
        /// <param name="id">ID del campesino</param>
        /// <param name="nacion">Nacion del campesino</param>
        /// <param name="profesion">Profesión del campesino</param>
        public Campesino(int id, ENacion nacion, string profesion) : base(id, nacion)
        {
            this.profesion = profesion;
        }

        /// <summary>
        /// Obtiene o establece el valor de profesion
        /// </summary>
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
