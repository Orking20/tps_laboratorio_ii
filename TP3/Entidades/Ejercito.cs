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

        /// <summary>
        /// Constructor vacío para generar archivos xml
        /// </summary>
        public Ejercito() : base()
        {

        }

        /// <summary>
        /// Inicializa los datos de un ejército
        /// </summary>
        /// <param name="id">ID del ejército</param>
        /// <param name="nombre">Nombre del ejército</param>
        /// <param name="nacion">Nación del ejército</param>
        /// <param name="tipo">Tipo de ejército</param>
        /// <param name="autonomia">Autonomía del ejército</param>
        /// <param name="cantMaxEjercito">Cantidad máxima de tropas individuales que tiene el ejército</param>
        public Ejercito(int id, string nombre, string nacion, T tipo, U autonomia, int cantMaxEjercito) : base(id, nacion)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Autonomia = autonomia;
            this.CantMaxEjercito = cantMaxEjercito;
        }

        /// <summary>
        /// Crea un nuevo ejército
        /// </summary>
        /// <param name="nombre">Nombre del ejército</param>
        /// <param name="nacion">Nación del ejército</param>
        /// <param name="tipo">Tipo de ejército</param>
        /// <param name="autonomia">Autonomía del ejército</param>
        /// <param name="cantMaxEjercito">Cantidad máxima de tropas individuales que tiene el ejército</param>
        /// <returns>Retorna el ejército creado</returns>
        public static Ejercito<T, U> AltaEjercito(string nombre, string nacion, T tipo, U autonomia, int cantMaxEjercito)
        {
            IdEstatico++;

            Ejercito<T, U> ejercitoNuevo = new Ejercito<T, U>(IdEstatico, nombre, nacion, tipo, autonomia, cantMaxEjercito);

            return ejercitoNuevo;
        }

        /// <summary>
        /// Elimina un ejército de una lista pasada por parámetros
        /// </summary>
        /// <param name="listaEjercitos">Lista de ejércitos</param>
        /// <param name="ejercito">Ejército a eliminar</param>
        public static void BajaEjercito(List<Ejercito<T, U>> listaEjercitos, Ejercito<T, U> ejercito)
        {
            listaEjercitos.Remove(ejercito);
        }

        /// <summary>
        /// Método de la interfaz IFuerzaMilitar que devuelve un texto informando que el ejército va a atacar
        /// </summary>
        /// <returns>Retorna el texto</returns>
        public string Atacar()
        {
            return $"{this.Nombre} van a las armas para atacar algún enemigo";
        }

        /// <summary>
        /// Método de la interfaz IFuerzaMilitar que devuelve un texto informando que el ejército va a defender
        /// </summary>
        /// <returns>Retorna el texto</returns>
        public string Defender()
        {
            return $"{this.Nombre} van a las armas y se preparan para defender a {this.Nacion}";
        }

        /// <summary>
        /// Obtiene o devuelve el nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (Validar.Nombre(value))
                {
                    this.nombre = value;
                }
            }
        }

        /// <summary>
        /// Obtiene o devuelve el tipo
        /// </summary>
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

        /// <summary>
        /// Obtiene o devuelve la autonomia
        /// </summary>
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

        /// <summary>
        /// Obtiene o devuelve cantidad máxima de tropas individuales del ejército
        /// </summary>
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
    }
}
