using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestsUnitarios
{
    [TestClass]
    public class Ejercito_Test
    {
        [TestMethod]
        public void Test_AltaEmpleado()
        {
            // ARRANGE
            Ejercito<ETipo, EAutonomia> ejercito;
            string nombre = "";
            string nacion = "";
            ETipo tipo = ETipo.Caballeria_ligera;
            EAutonomia autonomia = EAutonomia.Aceptable;
            int cantMaxEjercito = 600;


            // ACT
            ejercito = Ejercito<ETipo, EAutonomia>.AltaEjercito(nombre, nacion, tipo, autonomia, cantMaxEjercito);

            //ASSERT
            Assert.IsNotNull(ejercito);
            Assert.IsTrue(ejercito.Nombre != string.Empty);
            Assert.IsTrue(ejercito.Nacion != string.Empty);
        }
    }
}
