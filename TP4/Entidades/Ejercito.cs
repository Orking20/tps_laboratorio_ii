using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
	public delegate string DelegadoExportacion(Ejercito<string, string> ejercito);

	public class Ejercito<T, U> : Pueblo<string>, IFuerzaMilitar
	{
		private string nombre;
		private T tipo;
		private U autonomia;
		private int cantMaxEjercito;
		private bool flagExportar = true;
		private static StringBuilder ejercitosNoExportadosSB = new StringBuilder();

		public event DelegadoExportacion EventoExportacion;

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
		/// Muestra el nombre del ejército y su nación
		/// </summary>
		/// <param name="ejercito">Ejército a mostrar</param>
		/// <returns>Retorna el string con el nombre y nación del ejército</returns>
		public static string MostrarEjercito(Ejercito<string, string> ejercito)
		{
			return $"{ejercito.Nombre} de la nación {ejercito.Nacion} ha sido añadido\n";
		}
		
		/// <summary>
		/// Invoca al evento y agrega la información de los métodos a un StringBuilder
		/// </summary>
		/// <param name="ejercito">Ejército objetivo</param>
		public void NotificarCambiosSinGuardar(Ejercito<string, string> ejercito)
		{
            if (!ejercito.FlagExportar)
            {
				ejercitosNoExportadosSB.Append(EventoExportacion.Invoke(ejercito));
            }
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

		/// <summary>
		/// Obtiene o devuelve el flag que se encarga de evaluar
		/// que ejercito ya fue exportado y cual todavía no
		/// </summary>
		public bool FlagExportar
		{
			get
			{
				return this.flagExportar;
			}
			set
			{
				this.flagExportar = value;
			}
		}

		/// <summary>
		/// Obtiene o devuelve el StringBuilder que contiene a los ejércitos no exportados
		/// </summary>
		public static StringBuilder EjercitosNoExportadosSB
		{
			get
			{
				return ejercitosNoExportadosSB;
			}
			set
			{
				ejercitosNoExportadosSB = value;
			}
		}
	}
}
