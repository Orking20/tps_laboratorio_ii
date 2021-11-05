using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validar
    {
        /// <summary>
        /// Valida que la cadena ingresada sea un nombre válido
        /// </summary>
        /// <param name="nombre">Cadena a validar</param>
        /// <returns>Retorna true si la cadena es un nombre válido o false si no</returns>
        public static bool Nombre(string nombre)
        {
            bool retorno;

            retorno = EsSoloLetras(nombre) && nombre != string.Empty;

            return retorno;
        }

        /// <summary>
        /// Valida que una cadena contenga solo letras
        /// </summary>
        /// <param name="palabra">Palabra a validar</param>
        /// <returns>Retorna true si la cadena tiene solo letras o false si no</returns>
        private static bool EsSoloLetras(string palabra)
        {
            bool retorno = false;

            foreach (char letra in palabra)
            {
                if (!Char.IsLetter(letra) && letra != ' ')
                {
                    retorno = false;
                    break;
                }
                else
                {
                    retorno = true;
                }
            }

            return retorno;
        }
    }
}
