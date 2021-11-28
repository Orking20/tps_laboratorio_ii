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

            return ejercitoFiltrado.FiltrarDormenios(ejercitos);
        }

        /// <summary>
        /// Filtra una lista dejando solamente los provenientes de Eridie
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> Eridios(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            return ejercitoFiltrado.FiltrarEridios(ejercitos);
        }

        /// <summary>
        /// Filtra una lista dejando solamente los provenientes de Harrassia
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> Harrassianos(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            return ejercitoFiltrado.FiltrarHarrassianos(ejercitos);
        }

        /// <summary>
        /// Filtra una lista dejando solamente los provenientes guneares
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> Guneares(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            return ejercitoFiltrado.FiltrarGuneares(ejercitos);
        }

        /// <summary>
        /// Filtra una lista dejando solamente los ejércitos de infantería ligera
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> InfanteriaLigera(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            return ejercitoFiltrado.FiltrarInfanteriaLigera(ejercitos);
        }

        /// <summary>
        /// Filtra una lista dejando solamente los ejércitos con número de tropas individuales iguales o mayores a 5000
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> EjercitosMayoresA5000(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            return ejercitoFiltrado.FiltrarMayoresA5000(ejercitos);
        }

        /// <summary>
        /// Filtra una lista dejando solamente los ejércitos de infantería con entre 1000 y 5000 tropas individuales
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> InfanteriaEntre1000Y5000(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            return ejercitoFiltrado.FiltrarInfanteriaEntre1000Y5000(ejercitos);
        }

        /// <summary>
        /// Filtra una lista dejando solamente los ejércitos de caballería con una buena autonomía
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> CaballeriaConBuenaAutonomia(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            return ejercitoFiltrado.FiltrarCaballeriaConBuenaAutonomia(ejercitos);
        }

        /// <summary>
        /// Filtra una lista dejando solamente los ejércitos con una autonomía completa
        /// </summary>
        /// <param name="ejercitos">Lista a filtrar</param>
        /// <returns>Retorna la lista filtrada</returns>
        public static List<Ejercito<string, string>> AutonomiaCompleta(List<Ejercito<string, string>> ejercitos)
        {
            List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();

            return ejercitoFiltrado.FiltrarAutonomiaCompleta(ejercitos);
        }
    }
}
