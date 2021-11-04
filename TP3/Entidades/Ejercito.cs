using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Ejercito<T, U> : Pueblo<string>, IFuerzaMilitar
    {
        private string nombre;
        private T tipo;
        private U autonomia;
        private int cantMaxEjercito;

        public Ejercito() : base()
        {

        }

        public Ejercito(int id, string nombre, string nacion, T tipo, U autonomia, int cantMaxEjercito) : base(id, nacion)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Autonomia = autonomia;
            this.CantMaxEjercito = cantMaxEjercito;
        }

        public static Ejercito<T, U> AltaEjercito(string nombre, string nacion, T tipo, U autonomia, int cantMaxEjercito)
        {
            IdEstatico++;

            Ejercito<T, U> ejercitoNuevo = new Ejercito<T, U>(IdEstatico, nombre, nacion, tipo, autonomia, cantMaxEjercito);

            return ejercitoNuevo;
        }

        public static void BajaEjercito(List<Ejercito<T, U>> listaEjercitos, Ejercito<T, U> ejercito)
        {
            listaEjercitos.Remove(ejercito);
        }

        public string Atacar()
        {
            return $"{this.Nombre} van a las armas para atacar algún enemigo";
        }

        public string Defender()
        {
            return $"{this.Nombre} van a las armas y se preparan para defender a {this.Nacion}";
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

        public T Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public U Autonomia
        {
            get
            {
                return this.autonomia;
            }
            set
            {
                this.autonomia = value;
            }
        }

        public int CantMaxEjercito
        {
            get
            {
                return this.cantMaxEjercito;
            }
            set
            {
                this.cantMaxEjercito = value;
            }
        }

        /// <summary>
        /// Valida que la cadena ingresada sea un nombre válido
        /// </summary>
        /// <param name="nombre">Cadena a validar</param>
        /// <returns>Retorna true si la cadena es un nombre válido o false si no</returns>
        public static bool ValidarNombre(string nombre)
        {
            bool retorno;

            retorno = EsSoloLetras(nombre);

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
