using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Milicia : Campesino, IFuerzaMilitar
    {
        /// <summary>
        /// Inicializa los datos de la milicia
        /// </summary>
        /// <param name="id">ID de la milicia</param>
        /// <param name="nacion">Nación de la milicia</param>
        /// <param name="profesion">Profesión de la milicia</param>
        public Milicia(int id, ENacion nacion, string profesion) : base(id, nacion, profesion)
        {

        }

        /// <summary>
        /// Método de la interfaz IFuerzaMilitar que devuelve un texto informando que la milicia va a atacar
        /// </summary>
        /// <returns>Retorna el texto</returns>
        public string Atacar()
        {
            return "Algunos campesinos van a las armas para atacar a algún enemigo o para empezar una guerra civíl";
        }

        /// <summary>
        /// Método de la interfaz IFuerzaMilitar que devuelve un texto informando que la milicia va a defender
        /// </summary>
        /// <returns>Retorna el texto</returns>
        public string Defender()
        {
            return "Algunos campesinos van a las armas para defenderse de algún enemigo";
        }
    }
}
