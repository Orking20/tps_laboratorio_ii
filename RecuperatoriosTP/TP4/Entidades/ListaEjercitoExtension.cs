using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public static class ListaEjercitoExtension
	{
		/// <summary>
		/// Filtra los ejércitos que sean de Dormenia
		/// </summary>
		/// <param name="ejercitoFiltrado">Ejércitos filtrados</param>
		/// <param name="ejercitos">Todos los ejércitos</param>
		/// <returns>Retorna los ejércitos ya filtrados</returns>
		public static List<Ejercito<string, string>> FiltrarDormenios(this List<Ejercito<string, string>> ejercitoFiltrado, List<Ejercito<string, string>> ejercitos)
		{
			if (ejercitos.Count > 0)
			{
				ejercitos.ForEach(ejercito =>
				{
					if (ejercito.Nacion == ENacion.Dormenia.ToString())
					{
						ejercitoFiltrado.Add(ejercito);
					}
				});
			}

			return ejercitoFiltrado;
		}

		/// <summary>
		/// Filtra los ejércitos que sean de Eridie
		/// </summary>
		/// <param name="ejercitoFiltrado">Ejércitos filtrados</param>
		/// <param name="ejercitos">Todos los ejércitos</param>
		/// <returns>Retorna los ejércitos ya filtrados</returns>
		public static List<Ejercito<string, string>> FiltrarEridios(this List<Ejercito<string, string>> ejercitoFiltrado, List<Ejercito<string, string>> ejercitos)
		{
			if (ejercitos.Count > 0)
			{
				ejercitos.ForEach(ejercito =>
				{
					if (ejercito.Nacion == ENacion.Eride.ToString())
					{
						ejercitoFiltrado.Add(ejercito);
					}
				});
			}

			return ejercitoFiltrado;
		}

		/// <summary>
		/// Filtra los ejércitos que sean de Harrassia
		/// </summary>
		/// <param name="ejercitoFiltrado">Ejércitos filtrados</param>
		/// <param name="ejercitos">Todos los ejércitos</param>
		/// <returns>Retorna los ejércitos ya filtrados</returns>
		public static List<Ejercito<string, string>> FiltrarHarrassianos(this List<Ejercito<string, string>> ejercitoFiltrado, List<Ejercito<string, string>> ejercitos)
		{
			if (ejercitos.Count > 0)
			{
				ejercitos.ForEach(ejercito =>
				{
					if (ejercito.Nacion == ENacion.Harrassia.ToString())
					{
						ejercitoFiltrado.Add(ejercito);
					}
				});
			}

			return ejercitoFiltrado;
		}

		/// <summary>
		/// Filtra los ejércitos que sean de Gunear
		/// </summary>
		/// <param name="ejercitoFiltrado">Ejércitos filtrados</param>
		/// <param name="ejercitos">Todos los ejércitos</param>
		/// <returns>Retorna los ejércitos ya filtrados</returns>
		public static List<Ejercito<string, string>> FiltrarGuneares(this List<Ejercito<string, string>> ejercitoFiltrado, List<Ejercito<string, string>> ejercitos)
		{
			if (ejercitos.Count > 0)
			{
				ejercitos.ForEach(ejercito =>
				{
					if (ejercito.Nacion == ENacion.Gunear.ToString())
					{
						ejercitoFiltrado.Add(ejercito);
					}
				});
			}

			return ejercitoFiltrado;
		}

		/// <summary>
		/// Filtra los ejércitos que sean de infanterias ligeras
		/// </summary>
		/// <param name="ejercitoFiltrado">Ejércitos filtrados</param>
		/// <param name="ejercitos">Todos los ejércitos</param>
		/// <returns>Retorna los ejércitos ya filtrados</returns>
		public static List<Ejercito<string, string>> FiltrarInfanteriaLigera(this List<Ejercito<string, string>> ejercitoFiltrado, List<Ejercito<string, string>> ejercitos)
		{
			if (ejercitos.Count > 0)
			{
				ejercitos.ForEach(ejercito =>
				{
					if (ejercito.Tipo == ETipo.Infanteria_ligera.ToString())
					{
						ejercitoFiltrado.Add(ejercito);
					}
				});
			}

			return ejercitoFiltrado;
		}

		/// <summary>
		/// Filtra los ejércitos que tengas 5000 o más unidades
		/// </summary>
		/// <param name="ejercitoFiltrado">Ejércitos filtrados</param>
		/// <param name="ejercitos">Todos los ejércitos</param>
		/// <returns>Retorna los ejércitos ya filtrados</returns>
		public static List<Ejercito<string, string>> FiltrarMayoresA5000(this List<Ejercito<string, string>> ejercitoFiltrado, List<Ejercito<string, string>> ejercitos)
		{
			if (ejercitos.Count > 0)
			{
				ejercitos.ForEach(ejercito =>
				{
					if (ejercito.CantMaxEjercito >= 5000)
					{
						ejercitoFiltrado.Add(ejercito);
					}
				});
			}

			return ejercitoFiltrado;
		}

		/// <summary>
		/// Filtra los ejércitos que sean de infanterias y tengan entre 1000 y 5000 unidades
		/// </summary>
		/// <param name="ejercitoFiltrado">Ejércitos filtrados</param>
		/// <param name="ejercitos">Todos los ejércitos</param>
		/// <returns>Retorna los ejércitos ya filtrados</returns>
		public static List<Ejercito<string, string>> FiltrarInfanteriaEntre1000Y5000(this List<Ejercito<string, string>> ejercitoFiltrado, List<Ejercito<string, string>> ejercitos)
		{
			if (ejercitos.Count > 0)
			{
				ejercitos.ForEach(ejercito =>
				{
					if ((ejercito.Tipo == ETipo.Infanteria_de_soporte.ToString() || ejercito.Tipo == ETipo.Infanteria_ligera.ToString() ||
						ejercito.Tipo == ETipo.Infanteria_media.ToString() || ejercito.Tipo == ETipo.Infanteria_media_de_asalto.ToString() ||
						ejercito.Tipo == ETipo.Infanteria_mixta.ToString() || ejercito.Tipo == ETipo.Infanteria_pesada.ToString()) &&
						ejercito.CantMaxEjercito >= 1000 && ejercito.CantMaxEjercito <= 5000)
					{
						ejercitoFiltrado.Add(ejercito);
					}
				});
			}

			return ejercitoFiltrado;
		}

		/// <summary>
		/// Filtra los ejércitos que sean de caballeria y tengan buena autonomia
		/// </summary>
		/// <param name="ejercitoFiltrado">Ejércitos filtrados</param>
		/// <param name="ejercitos">Todos los ejércitos</param>
		/// <returns>Retorna los ejércitos ya filtrados</returns>
		public static List<Ejercito<string, string>> FiltrarCaballeriaConBuenaAutonomia(this List<Ejercito<string, string>> ejercitoFiltrado, List<Ejercito<string, string>> ejercitos)
		{
			if (ejercitos.Count > 0)
			{
				ejercitos.ForEach(ejercito =>
				{
					if ((ejercito.Autonomia == EAutonomia.Aceptable.ToString() || ejercito.Autonomia == EAutonomia.Alta.ToString() ||
						ejercito.Autonomia == EAutonomia.Casi_completa.ToString() || ejercito.Autonomia == EAutonomia.Completa.ToString()) &&
					   (ejercito.Tipo == ETipo.Caballeria_ligera.ToString() || ejercito.Tipo == ETipo.Caballeria_media.ToString() ||
						ejercito.Tipo == ETipo.Caballeria_pesada_de_asalto.ToString()))
					{
						ejercitoFiltrado.Add(ejercito);
					}
				});
			}

			return ejercitoFiltrado;
		}

		/// <summary>
		/// Filtra los ejércitos que tengan autonomia completa
		/// </summary>
		/// <param name="ejercitoFiltrado">Ejércitos filtrados</param>
		/// <param name="ejercitos">Todos los ejércitos</param>
		/// <returns>Retorna los ejércitos ya filtrados</returns>
		public static List<Ejercito<string, string>> FiltrarAutonomiaCompleta(this List<Ejercito<string, string>> ejercitoFiltrado, List<Ejercito<string, string>> ejercitos)
		{
			if (ejercitos.Count > 0)
			{
				ejercitos.ForEach(ejercito =>
				{
					if (ejercito.Autonomia == EAutonomia.Completa.ToString())
					{
						ejercitoFiltrado.Add(ejercito);
					}
				});
			}

			return ejercitoFiltrado;
		}
	}
}
