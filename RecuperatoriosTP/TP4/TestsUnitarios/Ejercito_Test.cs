using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestsUnitarios
{
    [TestClass]
    public class Ejercito_Test
    {
        [TestMethod]
        public void Test_AltaEjercito()
        {
            Ejercito<ETipo, EAutonomia> ejercito;
            string nombre = "Caballería Taunori";
            string nacion = "Dormenia";
            ETipo tipo = ETipo.Caballeria_ligera;
            EAutonomia autonomia = EAutonomia.Aceptable;
            int cantMaxEjercito = 600;

            ejercito = Ejercito<ETipo, EAutonomia>.AltaEjercito(nombre, nacion, tipo, autonomia, cantMaxEjercito);

            Assert.IsNotNull(ejercito);
            Assert.IsNotNull(ejercito.Nombre);
            Assert.IsNotNull(ejercito.Nacion);
        }

        [TestMethod]
        public void Test_BajaEjercito()
        {
            List<Ejercito<ETipo, EAutonomia>> ejercitos = new List<Ejercito<ETipo, EAutonomia>>();
            ejercitos.Add(Ejercito<ETipo, EAutonomia>.AltaEjercito("Caballería Taunori", "Dormenia", ETipo.Caballeria_media, EAutonomia.Aceptable, 600));
            ejercitos.Add(Ejercito<ETipo, EAutonomia>.AltaEjercito("Cuarta cohorte", "Eridie", ETipo.Arqueria_ligera, EAutonomia.Completa, 700));
            ejercitos.Add(Ejercito<ETipo, EAutonomia>.AltaEjercito("Camelleros", "Harrassia", ETipo.Caballeria_ligera, EAutonomia.Moderada, 950));
            ejercitos.Add(Ejercito<ETipo, EAutonomia>.AltaEjercito("Infiltrados de la novena cohorte", "Dormenia", ETipo.Infanteria_ligera, EAutonomia.Completa, 840));
            Ejercito<ETipo, EAutonomia> ejercito = ejercitos[1];

            Ejercito<ETipo, EAutonomia>.BajaEjercito(ejercitos, ejercito);

            Assert.IsFalse(ejercitos.Contains(ejercito));
        }
    }
}
