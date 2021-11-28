using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Analisis
    {
        private static string mensajeError;

        public static string MejorEjercito()
        {
            #region variables
            List<Ejercito<string, string>> ejercitos = BaseDeDatos.Select(out mensajeError);
            int totalTropasDormenias;
            int totalTropasDormeniasLigera;
            int totalTropasDormeniasPesadas;
            int totalTropasDormeniasAutonomiaCompleta;
            bool superioridadDormeniaNumerica = false;
            bool superioridadDormeniaLigera = false;
            bool superioridadDormeniaPesada = false;
            bool superioridadDormeniaAutonomia = false;

            int totalTropasEridias;
            int totalTropasEridiasLigera;
            int totalTropasEridiasPesadas;
            int totalTropasEridiasAutonomiaCompleta;
            bool superioridadEridiaNumerica = false;
            bool superioridadEridiaLigera = false;
            bool superioridadEridiaPesada = false;
            bool superioridadEridiaAutonomia = false;

            int totalTropasHarrassianas;
            int totalTropasHarrassianasLigera;
            int totalTropasHarrassianasPesadas;
            int totalTropasHarrassianasAutonomiaCompleta;
            bool superioridadHarrassianaNumerica = false;
            bool superioridadHarrassianaLigera = false;
            bool superioridadHarrassianaPesada = false;
            bool superioridadHarrassianaAutonomia = false;

            int totalTropasGuneares;
            int totalTropasGunearesLigeras;
            int totalTropasGunearesPesadas;
            int totalTropasGunearesAutonomiaCompleta;
            bool superioridadGunearesNumerica = false;
            bool superioridadGunearesLigera = false;
            bool superioridadGunearesPesada = false;
            bool superioridadGunearesAutonomia = false;

            int puntosDormenios = 0;
            int puntosEridios = 0;
            int puntosHarrassianos = 0;
            int puntosGuneares = 0;
            StringBuilder sb = new StringBuilder();
            string retorno;
            #endregion

            DatosDormenios(ejercitos, out totalTropasDormenias, out totalTropasDormeniasPesadas, out totalTropasDormeniasLigera, out totalTropasDormeniasAutonomiaCompleta);
            DatosEridios(ejercitos, out totalTropasEridias, out totalTropasEridiasPesadas, out totalTropasEridiasLigera, out totalTropasEridiasAutonomiaCompleta);
            DatosHarrassianos(ejercitos, out totalTropasHarrassianas, out totalTropasHarrassianasPesadas, out totalTropasHarrassianasLigera, out totalTropasHarrassianasAutonomiaCompleta);
            DatosGuneares(ejercitos, out totalTropasGuneares, out totalTropasGunearesPesadas, out totalTropasGunearesLigeras, out totalTropasGunearesAutonomiaCompleta);

            #region Puntaje
            if (totalTropasDormenias > totalTropasEridias && totalTropasDormenias > totalTropasHarrassianas && totalTropasDormenias > totalTropasGuneares)
            {
                sb.AppendLine($"•El total de tropas DORMENIAS ({totalTropasDormenias}) superan en número al total de tropas ERIDIAS ({totalTropasEridias}), HARRASSIANAS ({totalTropasHarrassianas}) y GUNEARES ({totalTropasGuneares})");
                puntosDormenios += 3;
                superioridadDormeniaNumerica = true;
            }
            else if (totalTropasEridias > totalTropasDormenias && totalTropasEridias > totalTropasHarrassianas && totalTropasEridias > totalTropasGuneares)
            {
                sb.AppendLine($"•El total de tropas ERIDIAS ({totalTropasEridias}) superan en número al total de tropas DORMENIAS ({totalTropasDormenias}), HARRASSIANAS ({totalTropasHarrassianas}) y GUNEARES ({totalTropasGuneares})");
                puntosEridios += 3;
                superioridadEridiaNumerica = true;
            }
            else if (totalTropasHarrassianas > totalTropasDormenias && totalTropasHarrassianas > totalTropasEridias && totalTropasHarrassianas > totalTropasGuneares)
            {
                sb.AppendLine($"•El total de tropas HARRASSIANAS ({totalTropasHarrassianas}) superan en número al total de tropas DORMENIAS ({totalTropasDormenias}), ERIDIAS ({totalTropasEridias}) y GUNEARES ({totalTropasGuneares})");
                puntosHarrassianos += 3;
                superioridadHarrassianaNumerica = true;
            }
            else
            {
                sb.AppendLine($"•El total de tropas GUNEARES ({totalTropasGuneares}) superan en número al total de tropas DORMENIAS ({totalTropasDormenias}), ERIDIAS ({totalTropasEridias}) y HARRASSIANAS ({totalTropasHarrassianas})");
                puntosGuneares += 3;
                superioridadGunearesNumerica = true;
            }

            if (totalTropasDormeniasLigera > totalTropasEridiasLigera && totalTropasDormeniasLigera > totalTropasHarrassianasLigera && totalTropasDormeniasLigera > totalTropasGunearesLigeras)
            {
                sb.AppendLine($"•El número de tropas DORMENIAS ligeras ({totalTropasDormeniasLigera}) superan al número de tropas ligeras ERIDIAS ({totalTropasEridiasLigera}), HARRASSIANAS ({totalTropasHarrassianasLigera}) y GUNEARES ({totalTropasGunearesLigeras})");
                puntosDormenios += 1;
                superioridadDormeniaLigera = true;
            }
            else if (totalTropasEridiasLigera > totalTropasDormeniasLigera && totalTropasEridiasLigera > totalTropasHarrassianasLigera && totalTropasEridiasLigera > totalTropasGunearesLigeras)
            {
                sb.AppendLine($"•El número de tropas ERIDIAS ligeras ({totalTropasEridiasLigera}) superan al número de tropas ligeras DORMENIAS ({totalTropasDormeniasLigera}), HARRASSIANAS ({totalTropasHarrassianasLigera}) y GUNEARES ({totalTropasGunearesLigeras})");
                puntosEridios += 1;
                superioridadEridiaLigera = true;
            }
            else if (totalTropasHarrassianasLigera > totalTropasDormeniasLigera && totalTropasHarrassianasLigera > totalTropasEridiasLigera && totalTropasHarrassianasLigera > totalTropasGunearesLigeras)
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS ligeras ({totalTropasHarrassianasLigera}) superan al número de tropas ligeras DORMENIAS ({totalTropasDormeniasLigera}), ERIDIAS ({totalTropasEridiasLigera}) y GUNEARES ({totalTropasGunearesLigeras})");
                puntosHarrassianos += 1;
                superioridadHarrassianaLigera = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas GUNEARES ligeras ({totalTropasGunearesLigeras}) superan al número de tropas ligeras DORMENIAS ({totalTropasDormeniasLigera}), ERIDIAS ({totalTropasEridiasLigera}) y HARRASSIANAS ({totalTropasHarrassianasLigera})");
                puntosGuneares += 1;
                superioridadGunearesLigera = true;
            }

            if (totalTropasDormeniasPesadas > totalTropasEridiasPesadas && totalTropasDormeniasPesadas > totalTropasHarrassianasPesadas && totalTropasDormeniasPesadas > totalTropasGunearesPesadas)
            {
                sb.AppendLine($"•El número de tropas DORMENIAS pesadas ({totalTropasDormeniasPesadas}) superan al número de tropas pesadas ERIDIAS ({totalTropasEridiasPesadas}), HARRASSIANAS ({totalTropasHarrassianasPesadas}) y GUNEARES ({totalTropasGunearesPesadas})");
                puntosDormenios += 3;
                superioridadDormeniaPesada = true;
            }
            else if (totalTropasEridiasPesadas > totalTropasDormeniasPesadas && totalTropasEridiasPesadas > totalTropasHarrassianasPesadas && totalTropasEridiasPesadas > totalTropasGunearesPesadas)
            {
                sb.AppendLine($"•El número de tropas ERIDIAS pesadas ({totalTropasEridiasPesadas}) superan al número de tropas pesadas DORMENIAS ({totalTropasDormeniasPesadas}), HARRASSIANAS ({totalTropasHarrassianasPesadas}) y GUNEARES ({totalTropasGunearesPesadas})");
                puntosEridios += 3;
                superioridadEridiaPesada = true;
            }
            else if (totalTropasHarrassianasPesadas > totalTropasDormeniasPesadas && totalTropasHarrassianasPesadas > totalTropasEridiasPesadas && totalTropasHarrassianasPesadas > totalTropasGunearesPesadas)
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS pesadas ({totalTropasHarrassianasPesadas}) superan al número de tropas pesadas DORMENIAS ({totalTropasDormeniasPesadas}), ERIDIAS ({totalTropasEridiasPesadas}) y GUNEARES ({totalTropasGunearesPesadas})");
                puntosHarrassianos += 3;
                superioridadHarrassianaPesada = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas GUNEARES pesadas ({totalTropasGunearesPesadas}) superan al número de tropas pesadas DORMENIAS ({totalTropasDormeniasPesadas}), ERIDIAS ({totalTropasEridiasPesadas}) y HARRASSIANAS ({totalTropasHarrassianasPesadas})");
                puntosGuneares += 1;
                superioridadGunearesPesada = true;
            }

            if (totalTropasDormeniasAutonomiaCompleta > totalTropasEridiasAutonomiaCompleta && totalTropasDormeniasAutonomiaCompleta > totalTropasHarrassianasAutonomiaCompleta && totalTropasDormeniasAutonomiaCompleta > totalTropasGunearesAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas DORMENIAS con autonomía completa ({totalTropasDormeniasAutonomiaCompleta}) superan al número de tropas con autonomía completa ERIDIAS ({totalTropasEridiasAutonomiaCompleta}), HARRASSIANAS ({totalTropasHarrassianasAutonomiaCompleta}) y GUNEARES ({totalTropasGunearesAutonomiaCompleta})");
                puntosDormenios += 2;
                superioridadDormeniaAutonomia = true;
            }
            else if (totalTropasEridiasAutonomiaCompleta > totalTropasDormeniasAutonomiaCompleta && totalTropasEridiasAutonomiaCompleta > totalTropasHarrassianasAutonomiaCompleta && totalTropasEridiasAutonomiaCompleta > totalTropasGunearesAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas ERIDIAS con autonomía completa ({totalTropasEridiasAutonomiaCompleta}) superan al número de tropas con autonomía completa DORMENIAS ({totalTropasDormeniasAutonomiaCompleta}), HARRASSIANAS ({totalTropasHarrassianasAutonomiaCompleta}) y GUNEARES ({totalTropasGunearesAutonomiaCompleta})");
                puntosEridios += 2;
                superioridadEridiaAutonomia = true;
            }
            else if (totalTropasHarrassianasAutonomiaCompleta > totalTropasDormeniasAutonomiaCompleta && totalTropasHarrassianasAutonomiaCompleta > totalTropasEridiasAutonomiaCompleta && totalTropasHarrassianasAutonomiaCompleta > totalTropasGunearesAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS con autonomía completa ({totalTropasHarrassianasAutonomiaCompleta}) superan al número de tropas con autonomía completa DORMENIAS ({totalTropasDormeniasAutonomiaCompleta}), ERIDIAS ({totalTropasEridiasAutonomiaCompleta}) y GUNEARES ({totalTropasGunearesAutonomiaCompleta})");
                puntosHarrassianos += 3;
                superioridadHarrassianaAutonomia = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas GUNEARES con autonomía completa ({totalTropasGunearesAutonomiaCompleta}) superan al número de tropas con autonomía completa DORMENIAS ({totalTropasDormeniasAutonomiaCompleta}), ERIDIAS ({totalTropasEridiasAutonomiaCompleta}) y HARRASSIANAS ({totalTropasHarrassianasAutonomiaCompleta})");
                puntosGuneares += 3;
                superioridadGunearesAutonomia = true;
            }

            if (puntosDormenios > puntosEridios && puntosDormenios > puntosHarrassianos && puntosDormenios > puntosGuneares)
            {
                sb.AppendLine(ResultadoDormenio(ref superioridadDormeniaNumerica, ref superioridadDormeniaLigera, ref superioridadDormeniaPesada, ref superioridadDormeniaAutonomia));
            }
            else if (puntosEridios > puntosDormenios && puntosEridios > puntosHarrassianos && puntosEridios > puntosGuneares)
            {
                sb.AppendLine(ResultadoEridio(ref superioridadEridiaNumerica, ref superioridadEridiaLigera, ref superioridadEridiaPesada, ref superioridadEridiaAutonomia));
            }
            else if (puntosHarrassianos > puntosDormenios && puntosHarrassianos > puntosEridios && puntosHarrassianos > puntosGuneares)
            {
                sb.AppendLine(ResultadoHarrassiano(ref superioridadHarrassianaNumerica, ref superioridadHarrassianaLigera, ref superioridadHarrassianaPesada, ref superioridadHarrassianaAutonomia));
            }
            else
            {
                sb.AppendLine(ResultadoGunear(ref superioridadGunearesNumerica, ref superioridadGunearesLigera, ref superioridadGunearesPesada, ref superioridadGunearesAutonomia));
            }
            #endregion

            if (mensajeError != "")
            {
                retorno = mensajeError;
            }
            else
            {
                retorno = sb.ToString();
            }

            return retorno;
        }

        public static string CompararDormeniosEridios()
        {
            List<Ejercito<string, string>> ejercitos = BaseDeDatos.Select(out mensajeError);
            int totalTropasDormenias;
            int totalTropasDormeniasLigera;
            int totalTropasDormeniasPesadas;
            int totalTropasDormeniasAutonomiaCompleta;
            bool superioridadDormeniaNumerica = false;
            bool superioridadDormeniaLigera = false;
            bool superioridadDormeniaPesada = false;
            bool superioridadDormeniaAutonomia = false;
            int totalTropasEridias;
            int totalTropasEridiasLigera;
            int totalTropasEridiasPesadas;
            int totalTropasEridiasAutonomiaCompleta;
            bool superioridadEridiaNumerica = false;
            bool superioridadEridiaLigera = false;
            bool superioridadEridiaPesada = false;
            bool superioridadEridiaAutonomia = false;
            int puntosDormenios = 0;
            int puntosEridios = 0;
            StringBuilder sb = new StringBuilder();
            string retorno;

            DatosDormenios(ejercitos, out totalTropasDormenias, out totalTropasDormeniasPesadas, out totalTropasDormeniasLigera, out totalTropasDormeniasAutonomiaCompleta);
            DatosEridios(ejercitos, out totalTropasEridias, out totalTropasEridiasPesadas, out totalTropasEridiasLigera, out totalTropasEridiasAutonomiaCompleta);

            if (totalTropasDormenias > totalTropasEridias)
            {
                sb.AppendLine($"•El total de tropas DORMENIAS ({totalTropasDormenias}) superan en número al total de tropas ERIDIAS ({totalTropasEridias})");
                puntosDormenios += 3;
                superioridadDormeniaNumerica = true;
            }
            else if (totalTropasEridias > totalTropasDormenias)
            {
                sb.AppendLine($"•El total de tropas ERIDIAS ({totalTropasEridias}) superan en número al total de tropas DORMENIAS ({totalTropasDormenias})");
                puntosEridios += 3;
                superioridadEridiaNumerica = true;
            }
            else
            {
                sb.AppendLine($"•El total de tropas DORMENIAS ({totalTropasDormenias}) empata en número al total de tropas ERIDIAS ({totalTropasEridias})");
            }

            if (totalTropasDormeniasLigera > totalTropasEridiasLigera)
            {
                sb.AppendLine($"•El número de tropas DORMENIAS ligeras ({totalTropasDormeniasLigera}) superan al número de tropas ERIDIAS ligeras ({totalTropasEridiasLigera})");
                puntosDormenios += 1;
                superioridadDormeniaLigera = true;
            }
            else if (totalTropasEridiasLigera > totalTropasDormeniasLigera)
            {
                sb.AppendLine($"•El número de tropas ERIDIAS ligeras ({totalTropasEridiasLigera}) superan al número de tropas DORMENIAS ligeras ({totalTropasDormeniasLigera})");
                puntosEridios += 1;
                superioridadEridiaLigera = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas DORMENIAS ligeras ({totalTropasDormeniasLigera}) empata al número de tropas ERIDIAS ligeras ({totalTropasEridiasLigera})");
            }

            if (totalTropasDormeniasPesadas > totalTropasEridiasPesadas)
            {
                sb.AppendLine($"•El número de tropas DORMENIAS pesadas ({totalTropasDormeniasPesadas}) superan al número de tropas ERIDIAS pesadas ({totalTropasEridiasPesadas})");
                puntosDormenios += 3;
                superioridadDormeniaPesada = true;
            }
            else if (totalTropasEridiasPesadas > totalTropasDormeniasPesadas)
            {
                sb.AppendLine($"•El número de tropas ERIDIAS pesadas ({totalTropasEridiasPesadas}) superan al número de tropas DORMENIAS pesadas ({totalTropasDormeniasPesadas})");
                puntosEridios += 3;
                superioridadEridiaPesada = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas DORMENIAS pesadas ({totalTropasDormeniasPesadas}) empata al número de tropas ERIDIAS pesadas ({totalTropasEridiasPesadas})");
            }

            if (totalTropasDormeniasAutonomiaCompleta > totalTropasEridiasAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas DORMENIAS con autonomía completa ({totalTropasDormeniasAutonomiaCompleta}) superan al número de tropas ERIDIAS con autonomía completa ({totalTropasEridiasAutonomiaCompleta})");
                puntosDormenios += 2;
                superioridadDormeniaAutonomia = true;
            }
            else if (totalTropasEridiasAutonomiaCompleta > totalTropasDormeniasAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas ERIDIAS con autonomía completa ({totalTropasEridiasAutonomiaCompleta}) superan al número de tropas DORMENIAS ({totalTropasDormeniasAutonomiaCompleta}) con autonomía completa");
                puntosEridios += 2;
                superioridadEridiaAutonomia = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas DORMENIAS con autonomía completa ({totalTropasDormeniasAutonomiaCompleta}) empata al número de tropas ERIDIAS con autonomía completa ({totalTropasEridiasAutonomiaCompleta})");
            }

            if (puntosDormenios > puntosEridios)
            {
                sb.AppendLine(ResultadoDormenio(ref superioridadDormeniaNumerica, ref superioridadDormeniaLigera, ref superioridadDormeniaPesada, ref superioridadDormeniaAutonomia));
            }
            else if (puntosEridios > puntosDormenios)
            {
                sb.AppendLine(ResultadoEridio(ref superioridadEridiaNumerica, ref superioridadEridiaLigera, ref superioridadEridiaPesada, ref superioridadEridiaAutonomia));
            }
            else
            {
                sb.AppendLine("Los ejércitos DORMENIOS los empatan en fuerza militar");
            }

            if (mensajeError != "")
            {
                retorno = mensajeError;
            }
            else
            {
                retorno = sb.ToString();
            }

            return retorno;
        }

        public static string CompararDormeniosHarrasianos()
        {
            List<Ejercito<string, string>> ejercitos = BaseDeDatos.Select(out mensajeError);
            int totalTropasDormenias;
            int totalTropasDormeniasLigera;
            int totalTropasDormeniasPesadas;
            int totalTropasDormeniasAutonomiaCompleta;
            bool superioridadDormeniaNumerica = false;
            bool superioridadDormeniaLigera = false;
            bool superioridadDormeniaPesada = false;
            bool superioridadDormeniaAutonomia = false;
            int puntosDormenios = 0;
            int totalTropasHarrassianas;
            int totalTropasHarrassianasLigera;
            int totalTropasHarrassianasPesadas;
            int totalTropasHarrassianasAutonomiaCompleta;
            bool superioridadHarrassianaNumerica = false;
            bool superioridadHarrassianaLigera = false;
            bool superioridadHarrassianaPesada = false;
            bool superioridadHarrassianaAutonomia = false;
            int puntosHarrassianos = 0;
            StringBuilder sb = new StringBuilder();
            string retorno;

            DatosDormenios(ejercitos, out totalTropasDormenias, out totalTropasDormeniasPesadas, out totalTropasDormeniasLigera, out totalTropasDormeniasAutonomiaCompleta);
            DatosHarrassianos(ejercitos, out totalTropasHarrassianas, out totalTropasHarrassianasPesadas, out totalTropasHarrassianasLigera, out totalTropasHarrassianasAutonomiaCompleta);

            if (totalTropasDormenias > totalTropasHarrassianas)
            {
                sb.AppendLine($"•El total de tropas DORMENIAS ({totalTropasDormenias}) superan en número al total de tropas HARRASSIANAS ({totalTropasHarrassianas})");
                puntosDormenios += 3;
                superioridadDormeniaNumerica = true;
            }
            else if (totalTropasHarrassianas > totalTropasDormenias)
            {
                sb.AppendLine($"•El total de tropas HARRASSIANAS ({totalTropasHarrassianas}) superan en número al total de tropas DORMENIAS ({totalTropasDormenias})");
                puntosHarrassianos += 3;
                superioridadHarrassianaNumerica = true;
            }
            else
            {
                sb.AppendLine($"•El total de tropas DORMENIAS ({totalTropasDormenias}) empata en número al total de tropas HARRASSIANAS ({totalTropasHarrassianas})");
            }

            if (totalTropasDormeniasLigera > totalTropasHarrassianasLigera)
            {
                sb.AppendLine($"•El número de tropas DORMENIAS ligeras ({totalTropasDormeniasLigera}) superan al número de tropas HARRASSIANAS ligeras ({totalTropasHarrassianasLigera})");
                puntosDormenios += 1;
                superioridadDormeniaLigera = true;
            }
            else if (totalTropasHarrassianasLigera > totalTropasDormeniasLigera)
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS ligeras ({totalTropasHarrassianasLigera}) superan al número de tropas DORMENIAS ligeras ({totalTropasDormeniasLigera})");
                puntosHarrassianos += 1;
                superioridadHarrassianaLigera = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas DORMENIAS ligeras ({totalTropasDormeniasLigera}) empatan al número de tropas HARRASSIANAS ligeras ({totalTropasHarrassianasLigera})");
            }

            if (totalTropasDormeniasPesadas > totalTropasHarrassianasPesadas)
            {
                sb.AppendLine($"•El número de tropas DORMENIAS pesadas ({totalTropasDormeniasPesadas}) superan al número de tropas HARRASSIANAS pesadas ({totalTropasHarrassianasPesadas})");
                puntosDormenios += 3;
                superioridadDormeniaPesada = true;
            }
            else if (totalTropasHarrassianasPesadas > totalTropasDormeniasPesadas)
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS pesadas ({totalTropasHarrassianasPesadas}) superan al número de tropas DORMENIAS pesadas ({totalTropasDormeniasPesadas})");
                puntosHarrassianos += 3;
                superioridadHarrassianaPesada = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas DORMENIAS pesadas ({totalTropasDormeniasPesadas}) empatan al número de tropas HARRASSIANAS pesadas ({totalTropasHarrassianasPesadas})");
            }

            if (totalTropasDormeniasAutonomiaCompleta > totalTropasHarrassianasAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas DORMENIAS con autonomía completa ({totalTropasDormeniasAutonomiaCompleta}) superan al número de tropas HARRASSIANAS con autonomía completa ({totalTropasHarrassianasAutonomiaCompleta})");
                puntosDormenios += 2;
                superioridadDormeniaAutonomia = true;
            }
            else if (totalTropasHarrassianasAutonomiaCompleta > totalTropasDormeniasAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS con autonomía completa ({totalTropasHarrassianasAutonomiaCompleta}) superan al número de tropas DORMENIAS ({totalTropasDormeniasAutonomiaCompleta}) con autonomía completa");
                puntosHarrassianos += 2;
                superioridadHarrassianaAutonomia = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas DORMENIAS con autonomía completa ({totalTropasDormeniasAutonomiaCompleta}) empatan al número de tropas HARRASSIANAS con autonomía completa ({totalTropasHarrassianasAutonomiaCompleta})");
            }

            if (puntosDormenios > puntosHarrassianos)
            {
                sb.AppendLine(ResultadoDormenio(ref superioridadDormeniaNumerica, ref superioridadDormeniaLigera, ref superioridadDormeniaPesada, ref superioridadDormeniaAutonomia));
            }
            else if (puntosHarrassianos > puntosDormenios)
            {
                sb.AppendLine(ResultadoHarrassiano(ref superioridadHarrassianaNumerica, ref superioridadHarrassianaLigera, ref superioridadHarrassianaPesada, ref superioridadHarrassianaAutonomia));
            }
            else
            {
                sb.AppendLine("Los ejércitos HARRASSIANOS los empatan en fuerza militar");
            }

            if (mensajeError != "")
            {
                retorno = mensajeError;
            }
            else
            {
                retorno = sb.ToString();
            }

            return retorno;
        }

        public static string CompararDormeniosGuneares()
        {
            List<Ejercito<string, string>> ejercitos = BaseDeDatos.Select(out mensajeError);
            int totalTropasDormenias;
            int totalTropasDormeniasLigera;
            int totalTropasDormeniasPesadas;
            int totalTropasDormeniasAutonomiaCompleta;
            bool superioridadDormeniaNumerica = false;
            bool superioridadDormeniaLigera = false;
            bool superioridadDormeniaPesada = false;
            bool superioridadDormeniaAutonomia = false;
            int puntosDormenios = 0;
            int totalTropasGuneares;
            int totalTropasGunearesLigera;
            int totalTropasGunearesPesadas;
            int totalTropasGunearesAutonomiaCompleta;
            bool superioridadGunearesNumerica = false;
            bool superioridadGunearesLigera = false;
            bool superioridadGunearesPesada = false;
            bool superioridadGunearesAutonomia = false;
            int puntosGuneares = 0;
            StringBuilder sb = new StringBuilder();
            string retorno;

            DatosDormenios(ejercitos, out totalTropasDormenias, out totalTropasDormeniasPesadas, out totalTropasDormeniasLigera, out totalTropasDormeniasAutonomiaCompleta);
            DatosGuneares(ejercitos, out totalTropasGuneares, out totalTropasGunearesPesadas, out totalTropasGunearesLigera, out totalTropasGunearesAutonomiaCompleta);

            if (totalTropasDormenias > totalTropasGuneares)
            {
                sb.AppendLine($"•El total de tropas DORMENIAS ({totalTropasDormenias}) superan en número al total de tropas GUNEARES ({totalTropasGuneares})");
                puntosDormenios += 3;
                superioridadDormeniaNumerica = true;
            }
            else if (totalTropasGuneares > totalTropasDormenias)
            {
                sb.AppendLine($"•El total de tropas GUNEARES ({totalTropasGuneares}) superan en número al total de tropas DORMENIAS ({totalTropasDormenias})");
                puntosGuneares += 3;
                superioridadGunearesNumerica = true;
            }
            else
            {
                sb.AppendLine($"•El total de tropas DORMENIAS ({totalTropasDormenias}) empatan en número al total de tropas GUNEARES ({totalTropasGuneares})");
            }

            if (totalTropasDormeniasLigera > totalTropasGunearesLigera)
            {
                sb.AppendLine($"•El número de tropas DORMENIAS ligeras ({totalTropasDormeniasLigera}) superan al número de tropas GUNEARES ligeras ({totalTropasGunearesLigera})");
                puntosDormenios += 1;
                superioridadDormeniaLigera = true;
            }
            else if (totalTropasGunearesLigera > totalTropasDormeniasLigera)
            {
                sb.AppendLine($"•El número de tropas GUNEARES ligeras ({totalTropasGunearesLigera}) superan al número de tropas DORMENIAS ligeras ({totalTropasDormeniasLigera})");
                puntosGuneares += 1;
                superioridadGunearesLigera = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas DORMENIAS ligeras ({totalTropasDormeniasLigera}) empatan al número de tropas GUNEARES ligeras ({totalTropasGunearesLigera})");
            }

            if (totalTropasDormeniasPesadas > totalTropasGunearesPesadas)
            {
                sb.AppendLine($"•El número de tropas DORMENIAS pesadas ({totalTropasDormeniasPesadas}) superan al número de tropas GUNEARES pesadas ({totalTropasGunearesPesadas})");
                puntosDormenios += 3;
                superioridadDormeniaPesada = true;
            }
            else if (totalTropasGunearesPesadas > totalTropasDormeniasPesadas)
            {
                sb.AppendLine($"•El número de tropas GUNEARES pesadas ({totalTropasGunearesPesadas}) superan al número de tropas DORMENIAS pesadas ({totalTropasDormeniasPesadas})");
                puntosGuneares += 3;
                superioridadGunearesPesada = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas DORMENIAS pesadas ({totalTropasDormeniasPesadas}) empatan al número de tropas GUNEARES pesadas ({totalTropasGunearesPesadas})");
            }

            if (totalTropasDormeniasAutonomiaCompleta > totalTropasGunearesAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas DORMENIAS con autonomía completa ({totalTropasDormeniasAutonomiaCompleta}) superan al número de tropas GUNEARES con autonomía completa ({totalTropasGunearesAutonomiaCompleta})");
                puntosDormenios += 2;
                superioridadDormeniaAutonomia = true;
            }
            else if (totalTropasGunearesAutonomiaCompleta > totalTropasDormeniasAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas GUNEARES con autonomía completa ({totalTropasGunearesAutonomiaCompleta}) superan al número de tropas DORMENIAS ({totalTropasDormeniasAutonomiaCompleta}) con autonomía completa");
                puntosGuneares += 2;
                superioridadGunearesAutonomia = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas DORMENIAS con autonomía completa ({totalTropasDormeniasAutonomiaCompleta}) empatan al número de tropas GUNEARES con autonomía completa ({totalTropasGunearesAutonomiaCompleta})");
            }

            if (puntosDormenios > puntosGuneares)
            {
                sb.AppendLine(ResultadoDormenio(ref superioridadDormeniaNumerica, ref superioridadDormeniaLigera, ref superioridadDormeniaPesada, ref superioridadDormeniaAutonomia));
            }
            else if (puntosGuneares > puntosDormenios)
            {
                sb.AppendLine(ResultadoGunear(ref superioridadGunearesNumerica, ref superioridadGunearesLigera, ref superioridadGunearesPesada, ref superioridadGunearesAutonomia));
            }
            else
            {
                sb.AppendLine("Los ejércitos DORMENIOS los empatan en fuerza militar");
            }

            if (mensajeError != "")
            {
                retorno = mensajeError;
            }
            else
            {
                retorno = sb.ToString();
            }

            return retorno;
        }

        public static string CompararEridiosHarrasianos()
        {
            List<Ejercito<string, string>> ejercitos = BaseDeDatos.Select(out mensajeError);
            int totalTropasEridias;
            int totalTropasEridiasLigera;
            int totalTropasEridiasPesadas;
            int totalTropasEridiasAutonomiaCompleta;
            bool superioridadEridiaNumerica = false;
            bool superioridadEridiaLigera = false;
            bool superioridadEridiaPesada = false;
            bool superioridadEridiaAutonomia = false;
            int puntosEridios = 0;
            int totalTropasHarrassianas;
            int totalTropasHarrassianasLigera;
            int totalTropasHarrassianasPesadas;
            int totalTropasHarrassianasAutonomiaCompleta;
            bool superioridadHarrassianaNumerica = false;
            bool superioridadHarrassianaLigera = false;
            bool superioridadHarrassianaPesada = false;
            bool superioridadHarrassianaAutonomia = false;
            int puntosHarrassianos = 0;
            StringBuilder sb = new StringBuilder();
            string retorno;

            DatosEridios(ejercitos, out totalTropasEridias, out totalTropasEridiasPesadas, out totalTropasEridiasLigera, out totalTropasEridiasAutonomiaCompleta);
            DatosHarrassianos(ejercitos, out totalTropasHarrassianas, out totalTropasHarrassianasPesadas, out totalTropasHarrassianasLigera, out totalTropasHarrassianasAutonomiaCompleta);

            if (totalTropasEridias > totalTropasHarrassianas)
            {
                sb.AppendLine($"•El total de tropas ERIDIAS ({totalTropasEridias}) superan en número al total de tropas HARRASSIANAS ({totalTropasHarrassianas})");
                puntosEridios += 3;
                superioridadEridiaNumerica = true;
            }
            else if (totalTropasHarrassianas > totalTropasEridias)
            {
                sb.AppendLine($"•El total de tropas HARRASSIANAS ({totalTropasHarrassianas}) superan en número al total de tropas ERIDIAS ({totalTropasEridias})");
                puntosHarrassianos += 3;
                superioridadHarrassianaNumerica = true;
            }
            else
            {
                sb.AppendLine($"•El total de tropas ERIDIAS ({totalTropasEridias}) empatan en número al total de tropas HARRASSIANAS ({totalTropasHarrassianas})");
            }

            if (totalTropasEridiasLigera > totalTropasHarrassianasLigera)
            {
                sb.AppendLine($"•El número de tropas ERIDIAS ligeras ({totalTropasEridiasLigera}) superan al número de tropas HARRASSIANAS ligeras ({totalTropasHarrassianasLigera})");
                puntosEridios += 1;
                superioridadEridiaLigera = true;
            }
            else if (totalTropasHarrassianasLigera > totalTropasEridiasLigera)
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS ligeras ({totalTropasHarrassianasLigera}) superan al número de tropas ERIDIAS ligeras ({totalTropasEridiasLigera})");
                puntosHarrassianos += 1;
                superioridadHarrassianaLigera = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas ERIDIAS ligeras ({totalTropasEridiasLigera}) empatan al número de tropas HARRASSIANAS ligeras ({totalTropasHarrassianasLigera})");
            }

            if (totalTropasEridiasPesadas > totalTropasHarrassianasPesadas)
            {
                sb.AppendLine($"•El número de tropas ERIDIAS pesadas ({totalTropasEridiasPesadas}) superan al número de tropas HARRASSIANAS pesadas ({totalTropasHarrassianasPesadas})");
                puntosEridios += 3;
                superioridadEridiaPesada = true;
            }
            else if (totalTropasHarrassianasPesadas > totalTropasEridiasPesadas)
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS pesadas ({totalTropasHarrassianasPesadas}) superan al número de tropas ERIDIAS pesadas ({totalTropasEridiasPesadas})");
                puntosHarrassianos += 3;
                superioridadHarrassianaPesada = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas ERIDIAS pesadas ({totalTropasEridiasPesadas}) empatan al número de tropas HARRASSIANAS pesadas ({totalTropasHarrassianasPesadas})");
            }

            if (totalTropasEridiasAutonomiaCompleta > totalTropasHarrassianasAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas ERIDIAS con autonomía completa ({totalTropasEridiasAutonomiaCompleta}) superan al número de tropas HARRASSIANAS con autonomía completa ({totalTropasHarrassianasAutonomiaCompleta})");
                puntosEridios += 2;
                superioridadEridiaAutonomia = true;
            }
            else if (totalTropasHarrassianasAutonomiaCompleta > totalTropasEridiasAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS con autonomía completa ({totalTropasHarrassianasAutonomiaCompleta}) superan al número de tropas ERIDIAS ({totalTropasEridiasAutonomiaCompleta}) con autonomía completa");
                puntosHarrassianos += 2;
                superioridadHarrassianaAutonomia = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas ERIDIAS con autonomía completa ({totalTropasEridiasAutonomiaCompleta}) empatan al número de tropas HARRASSIANAS con autonomía completa ({totalTropasHarrassianasAutonomiaCompleta})");
            }

            if (puntosEridios > puntosHarrassianos)
            {
                sb.AppendLine(ResultadoEridio(ref superioridadEridiaNumerica, ref superioridadEridiaLigera, ref superioridadEridiaPesada, ref superioridadEridiaAutonomia));
            }
            else if (puntosHarrassianos > puntosEridios)
            {
                sb.AppendLine(ResultadoHarrassiano(ref superioridadHarrassianaNumerica, ref superioridadHarrassianaLigera, ref superioridadHarrassianaPesada, ref superioridadHarrassianaAutonomia));
            }
            else
            {
                sb.AppendLine("Los ejércitos ERIDIOS los empatan en fuerza militar");
            }

            if (mensajeError != "")
            {
                retorno = mensajeError;
            }
            else
            {
                retorno = sb.ToString();
            }

            return retorno;
        }

        public static string CompararEridiosGuneares()
        {
            List<Ejercito<string, string>> ejercitos = BaseDeDatos.Select(out mensajeError);
            int totalTropasEridias;
            int totalTropasEridiasLigera;
            int totalTropasEridiasPesadas;
            int totalTropasEridiasAutonomiaCompleta;
            bool superioridadEridiaNumerica = false;
            bool superioridadEridiaLigera = false;
            bool superioridadEridiaPesada = false;
            bool superioridadEridiaAutonomia = false;
            int puntosEridios = 0;
            int totalTropasGuneares;
            int totalTropasGunearesLigeras;
            int totalTropasGunearesPesadas;
            int totalTropasGunearesAutonomiaCompleta;
            bool superioridadGunearesNumerica = false;
            bool superioridadGunearesLigera = false;
            bool superioridadGunearesPesada = false;
            bool superioridadGunearesAutonomia = false;
            int puntosGuneares = 0;
            StringBuilder sb = new StringBuilder();
            string retorno;

            DatosEridios(ejercitos, out totalTropasEridias, out totalTropasEridiasPesadas, out totalTropasEridiasLigera, out totalTropasEridiasAutonomiaCompleta);
            DatosGuneares(ejercitos, out totalTropasGuneares, out totalTropasGunearesPesadas, out totalTropasGunearesLigeras, out totalTropasGunearesAutonomiaCompleta);

            if (totalTropasEridias > totalTropasGuneares)
            {
                sb.AppendLine($"•El total de tropas ERIDIAS ({totalTropasEridias}) superan en número al total de tropas GUNEARES ({totalTropasGuneares})");
                puntosEridios += 3;
                superioridadEridiaNumerica = true;
            }
            else if (totalTropasGuneares > totalTropasEridias)
            {
                sb.AppendLine($"•El total de tropas GUNEARES ({totalTropasGuneares}) superan en número al total de tropas ERIDIAS ({totalTropasEridias})");
                puntosGuneares += 3;
                superioridadGunearesNumerica = true;
            }
            else
            {
                sb.AppendLine($"•El total de tropas ERIDIAS ({totalTropasEridias}) empatan en número al total de tropas GUNEARES ({totalTropasGuneares})");
            }

            if (totalTropasEridiasLigera > totalTropasGunearesLigeras)
            {
                sb.AppendLine($"•El número de tropas ERIDIAS ligeras ({totalTropasEridiasLigera}) superan al número de tropas GUNEARES ligeras ({totalTropasGunearesLigeras})");
                puntosEridios += 1;
                superioridadEridiaLigera = true;
            }
            else if (totalTropasGunearesLigeras > totalTropasEridiasLigera)
            {
                sb.AppendLine($"•El número de tropas GUNEARES ligeras ({totalTropasGunearesLigeras}) superan al número de tropas ERIDIAS ligeras ({totalTropasEridiasLigera})");
                puntosGuneares += 1;
                superioridadGunearesLigera = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas ERIDIAS ligeras ({totalTropasEridiasLigera}) empatan al número de tropas GUNEARES ligeras ({totalTropasGunearesLigeras})");
            }

            if (totalTropasEridiasPesadas > totalTropasGunearesPesadas)
            {
                sb.AppendLine($"•El número de tropas ERIDIAS pesadas ({totalTropasEridiasPesadas}) superan al número de tropas GUNEARES pesadas ({totalTropasGunearesPesadas})");
                puntosEridios += 3;
                superioridadEridiaPesada = true;
            }
            else if (totalTropasGunearesPesadas > totalTropasEridiasPesadas)
            {
                sb.AppendLine($"•El número de tropas GUNEARES pesadas ({totalTropasGunearesPesadas}) superan al número de tropas ERIDIAS pesadas ({totalTropasEridiasPesadas})");
                puntosGuneares += 3;
                superioridadGunearesPesada = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas ERIDIAS pesadas ({totalTropasEridiasPesadas}) empatan al número de tropas GUNEARES pesadas ({totalTropasGunearesPesadas})");
            }

            if (totalTropasEridiasAutonomiaCompleta > totalTropasGunearesAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas ERIDIAS con autonomía completa ({totalTropasEridiasAutonomiaCompleta}) superan al número de tropas GUNEARES con autonomía completa ({totalTropasGunearesAutonomiaCompleta})");
                puntosEridios += 2;
                superioridadEridiaAutonomia = true;
            }
            else if (totalTropasGunearesAutonomiaCompleta > totalTropasEridiasAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas GUNEARES con autonomía completa ({totalTropasGunearesAutonomiaCompleta}) superan al número de tropas ERIDIAS ({totalTropasEridiasAutonomiaCompleta}) con autonomía completa");
                puntosGuneares += 2;
                superioridadGunearesAutonomia = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas ERIDIAS con autonomía completa ({totalTropasEridiasAutonomiaCompleta}) empatan al número de tropas GUNEARES con autonomía completa ({totalTropasGunearesAutonomiaCompleta})");
            }

            if (puntosEridios > puntosGuneares)
            {
                sb.AppendLine(ResultadoEridio(ref superioridadEridiaNumerica, ref superioridadEridiaLigera, ref superioridadEridiaPesada, ref superioridadEridiaAutonomia));
            }
            else if (puntosGuneares > puntosEridios)
            {
                sb.AppendLine(ResultadoGunear(ref superioridadGunearesNumerica, ref superioridadGunearesLigera, ref superioridadGunearesPesada, ref superioridadGunearesAutonomia));
            }
            else
            {
                sb.AppendLine("Los ejércitos ERIDIOS los empatan en fuerza militar");
            }

            if (mensajeError != "")
            {
                retorno = mensajeError;
            }
            else
            {
                retorno = sb.ToString();
            }

            return retorno;
        }

        public static string CompararHarrassianosGuneares()
        {
            List<Ejercito<string, string>> ejercitos = BaseDeDatos.Select(out mensajeError);
            int totalTropasHarrassianas;
            int totalTropasHarrassianasLigera;
            int totalTropasHarrassianasPesadas;
            int totalTropasHarrassianasAutonomiaCompleta;
            bool superioridadHarrassianasNumerica = false;
            bool superioridadHarrassianasLigera = false;
            bool superioridadHarrassianasPesada = false;
            bool superioridadHarrassianasAutonomia = false;
            int puntosHarrassianos = 0;
            int totalTropasGuneares;
            int totalTropasGunearesLigeras;
            int totalTropasGunearesPesadas;
            int totalTropasGunearesAutonomiaCompleta;
            bool superioridadGunearesNumerica = false;
            bool superioridadGunearesLigera = false;
            bool superioridadGunearesPesada = false;
            bool superioridadGunearesAutonomia = false;
            int puntosGuneares = 0;
            StringBuilder sb = new StringBuilder();
            string retorno;

            DatosHarrassianos(ejercitos, out totalTropasHarrassianas, out totalTropasHarrassianasPesadas, out totalTropasHarrassianasLigera, out totalTropasHarrassianasAutonomiaCompleta);
            DatosGuneares(ejercitos, out totalTropasGuneares, out totalTropasGunearesPesadas, out totalTropasGunearesLigeras, out totalTropasGunearesAutonomiaCompleta);

            if (totalTropasHarrassianas > totalTropasGuneares)
            {
                sb.AppendLine($"•El total de tropas HARRASSIANAS ({totalTropasHarrassianas}) superan en número al total de tropas GUNEARES ({totalTropasGuneares})");
                puntosHarrassianos += 3;
                superioridadHarrassianasNumerica = true;
            }
            else if (totalTropasGuneares > totalTropasHarrassianas)
            {
                sb.AppendLine($"•El total de tropas GUNEARES ({totalTropasGuneares}) superan en número al total de tropas HARRASSIANAS ({totalTropasHarrassianas})");
                puntosGuneares += 3;
                superioridadGunearesNumerica = true;
            }
            else
            {
                sb.AppendLine($"•El total de tropas HARRASSIANAS ({totalTropasHarrassianas}) empatan en número al total de tropas GUNEARES ({totalTropasGuneares})");
            }

            if (totalTropasHarrassianasLigera > totalTropasGunearesLigeras)
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS ligeras ({totalTropasHarrassianasLigera}) superan al número de tropas GUNEARES ligeras ({totalTropasGunearesLigeras})");
                puntosHarrassianos += 1;
                superioridadHarrassianasLigera = true;
            }
            else if (totalTropasGunearesLigeras > totalTropasHarrassianasLigera)
            {
                sb.AppendLine($"•El número de tropas GUNEARES ligeras ({totalTropasGunearesLigeras}) superan al número de tropas HARRASSIANAS ligeras ({totalTropasHarrassianasLigera})");
                puntosGuneares += 1;
                superioridadGunearesLigera = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS ligeras ({totalTropasHarrassianasLigera}) superan al número de tropas GUNEARES ligeras ({totalTropasGunearesLigeras})");
            }

            if (totalTropasHarrassianasPesadas > totalTropasGunearesPesadas)
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS pesadas ({totalTropasHarrassianasPesadas}) superan al número de tropas GUNEARES pesadas ({totalTropasGunearesPesadas})");
                puntosHarrassianos += 3;
                superioridadHarrassianasPesada = true;
            }
            else if (totalTropasGunearesPesadas > totalTropasHarrassianasPesadas)
            {
                sb.AppendLine($"•El número de tropas GUNEARES pesadas ({totalTropasGunearesPesadas}) superan al número de tropas HARRASSIANAS pesadas ({totalTropasHarrassianasPesadas})");
                puntosGuneares += 3;
                superioridadGunearesPesada = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS pesadas ({totalTropasHarrassianasPesadas}) empatan al número de tropas GUNEARES pesadas ({totalTropasGunearesPesadas})");
            }

            if (totalTropasHarrassianasAutonomiaCompleta > totalTropasGunearesAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS con autonomía completa ({totalTropasHarrassianasAutonomiaCompleta}) superan al número de tropas GUNEARES con autonomía completa ({totalTropasGunearesAutonomiaCompleta})");
                puntosHarrassianos += 2;
                superioridadHarrassianasAutonomia = true;
            }
            else if (totalTropasGunearesAutonomiaCompleta > totalTropasHarrassianasAutonomiaCompleta)
            {
                sb.AppendLine($"•El número de tropas GUNEARES con autonomía completa ({totalTropasGunearesAutonomiaCompleta}) superan al número de tropas HARRASSIANAS ({totalTropasHarrassianasAutonomiaCompleta}) con autonomía completa");
                puntosGuneares += 2;
                superioridadGunearesAutonomia = true;
            }
            else
            {
                sb.AppendLine($"•El número de tropas HARRASSIANAS con autonomía completa ({totalTropasHarrassianasAutonomiaCompleta}) empatan al número de tropas GUNEARES con autonomía completa ({totalTropasGunearesAutonomiaCompleta})");
            }

            if (puntosHarrassianos > puntosGuneares)
            {
                sb.AppendLine(ResultadoHarrassiano(ref superioridadHarrassianasNumerica, ref superioridadHarrassianasLigera, ref superioridadHarrassianasPesada, ref superioridadHarrassianasAutonomia));
            }
            else if (puntosGuneares > puntosHarrassianos)
            {
                sb.AppendLine(ResultadoGunear(ref superioridadGunearesNumerica, ref superioridadGunearesLigera, ref superioridadGunearesPesada, ref superioridadGunearesAutonomia));
            }
            else
            {
                sb.AppendLine("Los ejércitos HARRASSIANOS los empatan en fuerza militar");
            }

            if (mensajeError != "")
            {
                retorno = mensajeError;
            }
            else
            {
                retorno = sb.ToString();
            }

            return retorno;
        }

        private static void DatosDormenios(List<Ejercito<string, string>> ejercitos, out int totalTropasDormenias, out int totalTropasDormeniasPesadas, out int totalTropasDormeniasLigera, out int totalTropasDormeniasAutonomiaCompleta)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;
            
            ejercitosFiltrados = Filtro.Dormenios(ejercitos);
            totalTropasDormenias = 0;
            totalTropasDormeniasPesadas = 0;
            totalTropasDormeniasLigera = 0;
            totalTropasDormeniasAutonomiaCompleta = 0;

            foreach (Ejercito<string, string> ejercito in ejercitosFiltrados)
            {
                totalTropasDormenias += ejercito.CantMaxEjercito;

                if (ejercito.Tipo == ETipo.Infanteria_pesada.ToString() || ejercito.Tipo == ETipo.Caballeria_pesada_de_asalto.ToString())
                {
                    totalTropasDormeniasPesadas += ejercito.CantMaxEjercito;
                }
                else if (ejercito.Tipo == ETipo.Infanteria_ligera.ToString() || ejercito.Tipo == ETipo.Arqueria_ligera.ToString() ||
                    ejercito.Tipo == ETipo.Caballeria_ligera.ToString())
                {
                    totalTropasDormeniasLigera += ejercito.CantMaxEjercito;
                }

                if (ejercito.Autonomia == EAutonomia.Completa.ToString())
                {
                    totalTropasDormeniasAutonomiaCompleta += ejercito.CantMaxEjercito;
                }
            }
        }

        private static void DatosEridios(List<Ejercito<string, string>> ejercitos, out int totalTropasEridias, out int totalTropasEridiasPesadas, out int totalTropasEridiasLigera, out int totalTropasEridiasAutonomiaCompleta)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;

            ejercitosFiltrados = Filtro.Eridios(ejercitos);
            totalTropasEridias = 0;
            totalTropasEridiasPesadas = 0;
            totalTropasEridiasLigera = 0;
            totalTropasEridiasAutonomiaCompleta = 0;

            foreach (Ejercito<string, string> ejercito in ejercitosFiltrados)
            {
                totalTropasEridias += ejercito.CantMaxEjercito;

                if (ejercito.Tipo == ETipo.Infanteria_pesada.ToString() || ejercito.Tipo == ETipo.Caballeria_pesada_de_asalto.ToString())
                {
                    totalTropasEridiasPesadas += ejercito.CantMaxEjercito;
                }
                else if (ejercito.Tipo == ETipo.Infanteria_ligera.ToString() || ejercito.Tipo == ETipo.Arqueria_ligera.ToString() ||
                    ejercito.Tipo == ETipo.Caballeria_ligera.ToString())
                {
                    totalTropasEridiasLigera += ejercito.CantMaxEjercito;
                }

                if (ejercito.Autonomia == EAutonomia.Completa.ToString())
                {
                    totalTropasEridiasAutonomiaCompleta += ejercito.CantMaxEjercito;
                }
            }
        }

        private static void DatosHarrassianos(List<Ejercito<string, string>> ejercitos, out int totalTropasHarrassianas, out int totalTropasHarrassianasPesadas, out int totalTropasHarrassianasLigera, out int totalTropasHarrassianasAutonomiaCompleta)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;

            ejercitosFiltrados = Filtro.Harrassianos(ejercitos);
            totalTropasHarrassianas = 0;
            totalTropasHarrassianasPesadas = 0;
            totalTropasHarrassianasLigera = 0;
            totalTropasHarrassianasAutonomiaCompleta = 0;

            foreach (Ejercito<string, string> ejercito in ejercitosFiltrados)
            {
                totalTropasHarrassianas += ejercito.CantMaxEjercito;

                if (ejercito.Tipo == ETipo.Infanteria_pesada.ToString() || ejercito.Tipo == ETipo.Caballeria_pesada_de_asalto.ToString())
                {
                    totalTropasHarrassianasPesadas += ejercito.CantMaxEjercito;
                }
                else if (ejercito.Tipo == ETipo.Infanteria_ligera.ToString() || ejercito.Tipo == ETipo.Arqueria_ligera.ToString() ||
                    ejercito.Tipo == ETipo.Caballeria_ligera.ToString())
                {
                    totalTropasHarrassianasLigera += ejercito.CantMaxEjercito;
                }

                if (ejercito.Autonomia == EAutonomia.Completa.ToString())
                {
                    totalTropasHarrassianasAutonomiaCompleta += ejercito.CantMaxEjercito;
                }
            }
        }

        private static void DatosGuneares(List<Ejercito<string, string>> ejercitos, out int totalTropasGuneares, out int totalTropasGunearesPesadas, out int totalTropasGunearesLigera, out int totalTropasGunearesAutonomiaCompleta)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;

            ejercitosFiltrados = Filtro.Guneares(ejercitos);
            totalTropasGuneares = 0;
            totalTropasGunearesPesadas = 0;
            totalTropasGunearesLigera = 0;
            totalTropasGunearesAutonomiaCompleta = 0;

            foreach (Ejercito<string, string> ejercito in ejercitosFiltrados)
            {
                totalTropasGuneares += ejercito.CantMaxEjercito;

                if (ejercito.Tipo == ETipo.Infanteria_pesada.ToString() || ejercito.Tipo == ETipo.Caballeria_pesada_de_asalto.ToString())
                {
                    totalTropasGunearesPesadas += ejercito.CantMaxEjercito;
                }
                else if (ejercito.Tipo == ETipo.Infanteria_ligera.ToString() || ejercito.Tipo == ETipo.Arqueria_ligera.ToString() ||
                    ejercito.Tipo == ETipo.Caballeria_ligera.ToString())
                {
                    totalTropasGunearesLigera += ejercito.CantMaxEjercito;
                }

                if (ejercito.Autonomia == EAutonomia.Completa.ToString())
                {
                    totalTropasGunearesAutonomiaCompleta += ejercito.CantMaxEjercito;
                }
            }
        }

        private static string ResultadoDormenio(ref bool superioridadDormeniaNumerica, ref bool superioridadDormeniaLigera, ref bool superioridadDormeniaPesada, ref bool superioridadDormeniaAutonomia)
        {
            StringBuilder sb = new StringBuilder();

            if (superioridadDormeniaNumerica && superioridadDormeniaLigera && superioridadDormeniaPesada && superioridadDormeniaAutonomia)
            {
                sb.AppendLine("-Los ejércitos DORMENIOS los superan en todos los sentidos\n");
            }
            else if (superioridadDormeniaNumerica && superioridadDormeniaLigera && superioridadDormeniaPesada && !superioridadDormeniaAutonomia)
            {
                sb.AppendLine("-Los ejércitos DORMENIOS los superan enormemente por su superioridad numérica, tanto en tropas ligeras como pesadas\n");
            }
            else if (superioridadDormeniaNumerica && superioridadDormeniaLigera && !superioridadDormeniaPesada && superioridadDormeniaAutonomia)
            {
                sb.AppendLine("-Los ejércitos DORMENIOS los superan por su superioridad numérica y mejor autonomía\n");
            }
            else if (superioridadDormeniaNumerica && !superioridadDormeniaLigera && superioridadDormeniaPesada && superioridadDormeniaAutonomia)
            {
                sb.AppendLine("-Los ejércitos DORMENIOS los superan enormemente por su superioridad numérica y mejor autonomía\n");
            }
            else if (!superioridadDormeniaNumerica && superioridadDormeniaLigera && superioridadDormeniaPesada && superioridadDormeniaAutonomia)
            {
                sb.AppendLine("-Los ejércitos DORMENIOS los superan por tener mayor cantidad de tropas ligeras y pesadas, y por su mejor autonomía\n");
            }
            else if (!superioridadDormeniaNumerica && !superioridadDormeniaLigera && superioridadDormeniaPesada && superioridadDormeniaAutonomia)
            {
                sb.AppendLine("-Los ejércitos DORMENIOS los superan parcialmente gracias a tener mejor autonomía y mayor cantidad de tropas pesadas\n");
            }
            else if (superioridadDormeniaNumerica && !superioridadDormeniaLigera && superioridadDormeniaPesada && !superioridadDormeniaAutonomia)
            {
                sb.AppendLine("-Los ejércitos DORMENIOS los superan gracias a tener mejor autonomía y mayor cantidad de tropas pesadas\n");
            }
            else if (superioridadDormeniaNumerica && !superioridadDormeniaLigera && !superioridadDormeniaPesada && superioridadDormeniaAutonomia)
            {
                sb.AppendLine("-Los ejércitos DORMENIOS los superan parcialmente gracias a tener mejor autonomía y tener la superioridad numérica\n");
            }

            return sb.ToString();
        }

        private static string ResultadoEridio(ref bool superioridadEridiaNumerica, ref bool superioridadEridiaLigera, ref bool superioridadEridiaPesada, ref bool superioridadEridiaAutonomia)
        {
            StringBuilder sb = new StringBuilder();

            if (superioridadEridiaNumerica && superioridadEridiaLigera && superioridadEridiaPesada && superioridadEridiaAutonomia)
            {
                sb.AppendLine("-Los ejércitos ERIDIOS los superan en todos los sentidos\n");
            }
            else if (superioridadEridiaNumerica && superioridadEridiaLigera && superioridadEridiaPesada && !superioridadEridiaAutonomia)
            {
                sb.AppendLine("-Los ejércitos ERIDIOS los superan enormemente por su superioridad numérica, tanto en tropas ligeras como pesadas\n");
            }
            else if (superioridadEridiaNumerica && superioridadEridiaLigera && !superioridadEridiaPesada && superioridadEridiaAutonomia)
            {
                sb.AppendLine("-Los ejércitos ERIDIOS los superan por su superioridad numérica y mejor autonomía\n");
            }
            else if (superioridadEridiaNumerica && !superioridadEridiaLigera && superioridadEridiaPesada && superioridadEridiaAutonomia)
            {
                sb.AppendLine("-Los ejércitos ERIDIOS los superan enormemente por su superioridad numérica y mejor autonomía\n");
            }
            else if (!superioridadEridiaNumerica && superioridadEridiaLigera && superioridadEridiaPesada && superioridadEridiaAutonomia)
            {
                sb.AppendLine("-Los ejércitos ERIDIOS los superan por tener mayor cantidad de tropas ligeras y pesadas, y por su mejor autonomía\n");
            }
            else if (!superioridadEridiaNumerica && !superioridadEridiaLigera && superioridadEridiaPesada && superioridadEridiaAutonomia)
            {
                sb.AppendLine("-Los ejércitos ERIDIOS los superan parcialmente gracias a tener mejor autonomía y mayor cantidad de tropas pesadas\n");
            }
            else if (superioridadEridiaNumerica && !superioridadEridiaLigera && superioridadEridiaPesada && !superioridadEridiaAutonomia)
            {
                sb.AppendLine("-Los ejércitos ERIDIOS los superan gracias a tener mejor autonomía y mayor cantidad de tropas pesadas\n");
            }
            else if (superioridadEridiaNumerica && !superioridadEridiaLigera && !superioridadEridiaPesada && superioridadEridiaAutonomia)
            {
                sb.AppendLine("-Los ejércitos ERIDIOS los superan parcialmente gracias a tener mejor autonomía y tener la superioridad numérica\n");
            }

            return sb.ToString();
        }

        private static string ResultadoHarrassiano(ref bool superioridadHarrassianaNumerica, ref bool superioridadHarrassianaLigera, ref bool superioridadHarrassianaPesada, ref bool superioridadHarrassianaAutonomia)
        {
            StringBuilder sb = new StringBuilder();

            if (superioridadHarrassianaNumerica && superioridadHarrassianaLigera && superioridadHarrassianaPesada && superioridadHarrassianaAutonomia)
            {
                sb.AppendLine("-Los ejércitos HARRASSIANOS los superan en todos los sentidos\n");
            }
            else if (superioridadHarrassianaNumerica && superioridadHarrassianaLigera && superioridadHarrassianaPesada && !superioridadHarrassianaAutonomia)
            {
                sb.AppendLine("-Los ejércitos HARRASSIANOS los superan enormemente por su superioridad numérica, tanto en tropas ligeras como pesadas\n");
            }
            else if (superioridadHarrassianaNumerica && superioridadHarrassianaLigera && !superioridadHarrassianaPesada && superioridadHarrassianaAutonomia)
            {
                sb.AppendLine("-Los ejércitos HARRASSIANOS los superan por su superioridad numérica y mejor autonomía\n");
            }
            else if (superioridadHarrassianaNumerica && !superioridadHarrassianaLigera && superioridadHarrassianaPesada && superioridadHarrassianaAutonomia)
            {
                sb.AppendLine("-Los ejércitos HARRASSIANOS los superan enormemente por su superioridad numérica y mejor autonomía\n");
            }
            else if (!superioridadHarrassianaNumerica && superioridadHarrassianaLigera && superioridadHarrassianaPesada && superioridadHarrassianaAutonomia)
            {
                sb.AppendLine("-Los ejércitos HARRASSIANOS los superan por tener mayor cantidad de tropas ligeras y pesadas, y por su mejor autonomía\n");
            }
            else if (!superioridadHarrassianaNumerica && !superioridadHarrassianaLigera && superioridadHarrassianaPesada && superioridadHarrassianaAutonomia)
            {
                sb.AppendLine("-Los ejércitos HARRASSIANOS los superan parcialmente gracias a tener mejor autonomía y mayor cantidad de tropas pesadas\n");
            }
            else if (superioridadHarrassianaNumerica && !superioridadHarrassianaLigera && superioridadHarrassianaPesada && !superioridadHarrassianaAutonomia)
            {
                sb.AppendLine("-Los ejércitos HARRASSIANOS los superan gracias a tener mejor autonomía y mayor cantidad de tropas pesadas\n");
            }
            else if (superioridadHarrassianaNumerica && !superioridadHarrassianaLigera && !superioridadHarrassianaPesada && superioridadHarrassianaAutonomia)
            {
                sb.AppendLine("-Los ejércitos HARRASSIANOS los superan parcialmente gracias a tener mejor autonomía y tener la superioridad numérica\n");
            }

            return sb.ToString();
        }

        private static string ResultadoGunear(ref bool superioridadGunearNumerica, ref bool superioridadGunearLigera, ref bool superioridadGunearPesada, ref bool superioridadGunearAutonomia)
        {
            StringBuilder sb = new StringBuilder();

            if (superioridadGunearNumerica && superioridadGunearLigera && superioridadGunearPesada && superioridadGunearAutonomia)
            {
                sb.AppendLine("-Los ejércitos GUNEARES los superan en todos los sentidos\n");
            }
            else if (superioridadGunearNumerica && superioridadGunearLigera && superioridadGunearPesada && !superioridadGunearAutonomia)
            {
                sb.AppendLine("-Los ejércitos GUNEARES los superan enormemente por su superioridad numérica, tanto en tropas ligeras como pesadas\n");
            }
            else if (superioridadGunearNumerica && superioridadGunearLigera && !superioridadGunearPesada && superioridadGunearAutonomia)
            {
                sb.AppendLine("-Los ejércitos GUNEARES los superan por su superioridad numérica y mejor autonomía\n");
            }
            else if (superioridadGunearNumerica && !superioridadGunearLigera && superioridadGunearPesada && superioridadGunearAutonomia)
            {
                sb.AppendLine("-Los ejércitos GUNEARES los superan enormemente por su superioridad numérica y mejor autonomía\n");
            }
            else if (!superioridadGunearNumerica && superioridadGunearLigera && superioridadGunearPesada && superioridadGunearAutonomia)
            {
                sb.AppendLine("-Los ejércitos GUNEARES los superan por tener mayor cantidad de tropas ligeras y pesadas, y por su mejor autonomía\n");
            }
            else if (!superioridadGunearNumerica && !superioridadGunearLigera && superioridadGunearPesada && superioridadGunearAutonomia)
            {
                sb.AppendLine("-Los ejércitos GUNEARES los superan parcialmente gracias a tener mejor autonomía y mayor cantidad de tropas pesadas\n");
            }
            else if (superioridadGunearNumerica && !superioridadGunearLigera && superioridadGunearPesada && !superioridadGunearAutonomia)
            {
                sb.AppendLine("-Los ejércitos GUNEARES los superan gracias a tener mejor autonomía y mayor cantidad de tropas pesadas\n");
            }
            else if (superioridadGunearNumerica && !superioridadGunearLigera && !superioridadGunearPesada && superioridadGunearAutonomia)
            {
                sb.AppendLine("-Los ejércitos GUNEARES los superan parcialmente gracias a tener mejor autonomía y tener la superioridad numérica\n");
            }

            return sb.ToString();
        }
    }
}
