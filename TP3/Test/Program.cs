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
            string error;

            Ejercito<string, string> ejercito = new Ejercito<string, string>(1, "Ejercito regular", "Dormenia", "Infanteria ligera", "Alta", 40000);
            Milicia milicia = new Milicia(1, ENacion.Gunear, "Marinero");

            Console.WriteLine(ejercito.Atacar());
            Console.WriteLine(ejercito.Defender());

            Console.WriteLine(milicia.Atacar());
            Console.WriteLine(milicia.Defender());

            listaEjercitos.Add(Ejercito<string, string>.AltaEjercito("Legión del sur", "Eridie", "Infanteria media", "Casi completa", 10000));

            listaEjercitos.Add(ejercito);

            Archivo.EscribirCsv(listaEjercitos, "Ejercitos.csv", out error);
        }
    }
}
