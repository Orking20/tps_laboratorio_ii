using System;
using System.Collections.Generic;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ejercito<string, string>> listaEjercitos = new List<Ejercito<string, string>>();
            List<Ejercito<string, string>> listaFiltrada = new List<Ejercito<string, string>>();
            string error;

            Ejercito<string, string> ejercito = new Ejercito<string, string>(42, "Ejercito regular", "Dormenia", "Infanteria ligera", "Alta", 40000);
            Milicia milicia = new Milicia(1, ENacion.Gunear, "Marinero");

            Console.WriteLine(ejercito.Atacar());
            Console.WriteLine(ejercito.Defender());

            Console.WriteLine(milicia.Atacar());
            Console.WriteLine(milicia.Defender());

            listaEjercitos = Archivo.LeerCsv("EjercitosConsola.csv", out error);

            listaEjercitos.Add(Ejercito<string, string>.AltaEjercito("Legión del sur", "Dormenia", "Infanteria media", "Casi completa", 10000));
            listaEjercitos.Add(ejercito);

            Console.WriteLine("\nLista de ejercitos:");
            foreach (Ejercito<string, string> auxEjercito in listaEjercitos)
            {
                Console.WriteLine(auxEjercito.Nombre);
            }

            listaFiltrada = Filtro.Eridios(listaEjercitos);
            Console.WriteLine("\nLista filtrada por ejercitos con 5000 o más unidades:");
            foreach (Ejercito<string, string> auxEjercito in listaFiltrada)
            {
                Console.WriteLine(auxEjercito.Nombre);
            }

            Archivo.EscribirCsv(listaEjercitos, "EjercitosConsola.csv", out error);
        }
    }
}
