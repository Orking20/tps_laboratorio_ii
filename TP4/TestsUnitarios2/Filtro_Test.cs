using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestsUnitarios2
{
    [TestClass]
    public class Filtro_Test
    {
		List<Ejercito<string, string>> ejercitos = new List<Ejercito<string, string>>()
		{
			new Ejercito<string, string>(1, "Caballería Taunori", "Dormenia", "Caballeria_media", "Moderada", 400),
			new Ejercito<string, string>(2, "Arqueria de la segunda cohorte", "Eridie", "Arqueria_ligera", "Completa", 270),
			new Ejercito<string, string>(3, "Guerreros Sigvar", "Gunear", "Infanteria_media", "Aceptable", 1240),
			new Ejercito<string, string>(4, "Correccion", "Dormenia", "Infanteria_ligera", "Desconocida", 6000),
			new Ejercito<string, string>(5, "Inflitradores de la novena cohorte", "Eridie", "Infanteria_ligera", "Completa", 560),
			new Ejercito<string, string>(6, "Camelleros", "Harrassia", "Caballeria_ligera", "Alta", 2200),
			new Ejercito<string, string>(7, "Peltasta de la segunda cohorte", "Eridie", "Infanteria_ligera", "Completa", 850)
		};

		[TestMethod]
		public void Test_Dormenios()
		{
			List<Ejercito<string, string>> ejercitosEsperados = new List<Ejercito<string, string>>()
			{
				new Ejercito<string, string>(1, "Caballería Taunori", "Dormenia", "Caballeria_media", "Moderada", 400),
				new Ejercito<string, string>(4, "Correccion", "Dormenia", "Infanteria_ligera", "Desconocida", 6000)
			};
			List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();
			bool flag = false;

			ejercitoFiltrado.FiltrarDormenios(this.ejercitos);

			if (ejercitoFiltrado.Count == ejercitosEsperados.Count)
			{
				for (int i = 0; i < ejercitoFiltrado.Count; i++)
				{
					if (ejercitoFiltrado[i].Nacion == ejercitosEsperados[i].Nacion)
					{
						flag = true;
					}
					else
					{
						Assert.Fail();
						break;
					}
				}
			}
			else
			{
				Assert.Fail();
			}

			Assert.IsTrue(flag);
		}

		[TestMethod]
		public void Test_InfanteriaLigera()
		{
			List<Ejercito<string, string>> ejercitosEsperados = new List<Ejercito<string, string>>()
			{
				new Ejercito<string, string>(4, "Correccion", "Dormenia", "Infanteria_ligera", "Desconocida", 6000),
				new Ejercito<string, string>(5, "Inflitradores de la novena cohorte", "Eridie", "Infanteria_ligera", "Completa", 560),
				new Ejercito<string, string>(7, "Peltasta de la segunda cohorte", "Eridie", "Infanteria_ligera", "Completa", 850)
			};
			List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();
			bool flag = false;

			ejercitoFiltrado.FiltrarInfanteriaLigera(this.ejercitos);

			if (ejercitoFiltrado.Count == ejercitosEsperados.Count)
			{
				for (int i = 0; i < ejercitoFiltrado.Count; i++)
				{
					if (ejercitoFiltrado[i].Tipo == ejercitosEsperados[i].Tipo)
					{
						flag = true;
					}
					else
					{
						Assert.Fail();
						break;
					}
				}
			}
			else
			{
				Assert.Fail();
			}

			Assert.IsTrue(flag);
		}

		[TestMethod]
		public void Test_AutonomiaCompleta()
		{
			List<Ejercito<string, string>> ejercitosEsperados = new List<Ejercito<string, string>>()
			{
				new Ejercito<string, string>(2, "Arqueria de la segunda cohorte", "Eridie", "Arqueria_ligera", "Completa", 270),
				new Ejercito<string, string>(5, "Inflitradores de la novena cohorte", "Eridie", "Infanteria_ligera", "Completa", 560),
				new Ejercito<string, string>(7, "Peltasta de la segunda cohorte", "Eridie", "Infanteria_ligera", "Completa", 850)
			};
			List<Ejercito<string, string>> ejercitoFiltrado = new List<Ejercito<string, string>>();
			bool flag = false;

			ejercitoFiltrado.FiltrarAutonomiaCompleta(this.ejercitos);

			if (ejercitoFiltrado.Count == ejercitosEsperados.Count)
			{
				for (int i = 0; i < ejercitoFiltrado.Count; i++)
				{
					if (ejercitoFiltrado[i].Autonomia == ejercitosEsperados[i].Autonomia)
					{
						flag = true;
					}
					else
					{
						Assert.Fail();
						break;
					}
				}
			}
			else
			{
				Assert.Fail();
			}

			Assert.IsTrue(flag);
		}
	}
}
