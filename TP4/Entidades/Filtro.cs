using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Filtro
    {
        /// <summary>
        /// Filtra una lista dejando solamente los provenientes de Dormenia
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> Dormenios(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            if (ejercitos.Count > 0)
            {
                foreach (Ejercito<string, string> ejercito in ejercitos)
                {
                    if (ejercito.Nacion == ENacion.Dormenia.ToString())
                    {
                        ejercitoFiltrado.Add(ejercito);
                    }
                }
            }

            return ejercitoFiltrado;
        }

        /// <summary>
        /// Filtra una lista dejando solamente los provenientes de Eridie
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> Eridios(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            if (ejercitos.Count > 0)
            {
                foreach (Ejercito<string, string> ejercito in ejercitos)
                {
                    if (ejercito.Nacion == ENacion.Eride.ToString())
                    {
                        ejercitoFiltrado.Add(ejercito);
                    }
                }
            }

            return ejercitoFiltrado;
        }

        /// <summary>
        /// Filtra una lista dejando solamente los provenientes de Harrassia
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> Harrassianos(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            if (ejercitos.Count > 0)
            {
                foreach (Ejercito<string, string> ejercito in ejercitos)
                {
                    if (ejercito.Nacion == ENacion.Harrassia.ToString())
                    {
                        ejercitoFiltrado.Add(ejercito);
                    }
                }
            }

            return ejercitoFiltrado;
        }

        /// <summary>
        /// Filtra una lista dejando solamente los provenientes guneares
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> Guneares(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            if (ejercitos.Count > 0)
            {
                foreach (Ejercito<string, string> ejercito in ejercitos)
                {
                    if (ejercito.Nacion == ENacion.Gunear.ToString())
                    {
                        ejercitoFiltrado.Add(ejercito);
                    }
                }
            }

            return ejercitoFiltrado;
        }

        /// <summary>
        /// Filtra una lista dejando solamente los ejércitos de infantería ligera
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> InfanteriaLigera(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            if (ejercitos.Count > 0)
            {
                foreach (Ejercito<string, string> ejercito in ejercitos)
                {
                    if (ejercito.Tipo == ETipo.Infanteria_ligera.ToString())
                    {
                        ejercitoFiltrado.Add(ejercito);
                    }
                }
            }

            return ejercitoFiltrado;
        }

        /// <summary>
        /// Filtra una lista dejando solamente los ejércitos con número de tropas individuales iguales o mayores a 5000
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> EjercitosMayoresA5000(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            if (ejercitos.Count > 0)
            {
                foreach (Ejercito<string, string> ejercito in ejercitos)
                {
                    if (ejercito.CantMaxEjercito >= 5000)
                    {
                        ejercitoFiltrado.Add(ejercito);
                    }
                }
            }

            return ejercitoFiltrado;
        }

        /// <summary>
        /// Filtra una lista dejando solamente los ejércitos de infantería con entre 1000 y 5000 tropas individuales
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> InfanteriaEntre1000Y5000(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            if (ejercitos.Count > 0)
            {
                foreach (Ejercito<string, string> ejercito in ejercitos)
                {
                    if ((ejercito.Tipo == ETipo.Infanteria_de_soporte.ToString() || ejercito.Tipo == ETipo.Infanteria_ligera.ToString() ||
                        ejercito.Tipo == ETipo.Infanteria_media.ToString() || ejercito.Tipo == ETipo.Infanteria_media_de_asalto.ToString() ||
                        ejercito.Tipo == ETipo.Infanteria_mixta.ToString() || ejercito.Tipo == ETipo.Infanteria_pesada.ToString()) &&
                        ejercito.CantMaxEjercito >= 1000 && ejercito.CantMaxEjercito <= 5000)
                    {
                        ejercitoFiltrado.Add(ejercito);
                    }
                }
            }

            return ejercitoFiltrado;
        }

        /// <summary>
        /// Filtra una lista dejando solamente los ejércitos de caballería con una buena autonomía
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> CaballeriaConBuenaAutonomia(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            if (ejercitos.Count > 0)
            {
                foreach (Ejercito<string, string> ejercito in ejercitos)
                {
                    if ((ejercito.Autonomia == EAutonomia.Aceptable.ToString() || ejercito.Autonomia == EAutonomia.Alta.ToString() ||
                        ejercito.Autonomia == EAutonomia.Casi_completa.ToString() || ejercito.Autonomia == EAutonomia.Completa.ToString()) &&
                        (ejercito.Tipo == ETipo.Caballeria_ligera.ToString() || ejercito.Tipo == ETipo.Caballeria_media.ToString() ||
                        ejercito.Tipo == ETipo.Caballeria_pesada_de_asalto.ToString()))
                    {
                        ejercitoFiltrado.Add(ejercito);
                    }
                }
            }

            return ejercitoFiltrado;
        }

        /// <summary>
        /// Filtra una lista dejando solamente los ejércitos con una autonomía completa
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> AutonomiaCompleta(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            if (ejercitos.Count > 0)
            {
                foreach (Ejercito<string, string> ejercito in ejercitos)
                {
                    if (ejercito.Autonomia == EAutonomia.Completa.ToString())
                    {
                        ejercitoFiltrado.Add(ejercito);
                    }
                }
            }

            return ejercitoFiltrado;
        }
    }
}
