using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Ejercito<T, U, V>
    {
        private static int idEjercito;
        private int id;
        private string nombre;
        private T nacion;
        private U tipo;
        private V autonomia;
        private int cantMaxEjercito;

        public Ejercito(int idEjercito, string nombre, T nacion, U tipo, V autonomia, int cantMaxEjercito)
        {
            this.id = idEjercito;
            this.Nombre = nombre;
            this.Nacion = nacion;
            this.Tipo = tipo;
            this.Autonomia = autonomia;
            this.CantMaxEjercito = cantMaxEjercito;
        }

        public static Ejercito<T, U, V> AltaEjercito(string nombre, T nacion, U tipo, V autonomia, int cantMaxEjercito)
        {
            idEjercito++;

            Ejercito<T, U, V> ejercitoNuevo = new Ejercito<T, U, V>(idEjercito, nombre, nacion, tipo, autonomia, cantMaxEjercito);

            return ejercitoNuevo;
        }

        public static void BajaEjercito(List<Ejercito<T, U, V>> listaEjercitos, Ejercito<T, U, V> ejercito)
        {
            listaEjercitos.Remove(ejercito);
        }

        public static int IdEstatico
        {
            get
            {
                return idEjercito;
            }
            set
            {
                idEjercito = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
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

        public U Tipo
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

        public V Autonomia
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
