using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Archivo
    {
        public static void Escribir(List<Ejercito<string, string, string>> ejercitos, out string error)
        {
            string path;
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                path = Directory.GetCurrentDirectory();

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter escritor = new StreamWriter($"{path}\\Ejercitos.csv"))
                {
                    escritor.WriteLine("ID;NOMBRE;NACION;TIPO;AUTONOMIA;CANTIDAD");

                    for (int i = 0; i < ejercitos.Count; i++)
                    {
                        escritor.WriteLine($"{ejercitos[i].Id};{ejercitos[i].Nombre};{ejercitos[i].Nacion};{ejercitos[i].Tipo};{ejercitos[i].Autonomia};{ejercitos[i].CantMaxEjercito}");
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                stringBuilder.Append("Usted no tiene autorización para acceder a esta ruta.");
            }
            catch (NotSupportedException)
            {
                stringBuilder.Append("Un método invocado no es compatible o se está intentando leer, buscar o escribir en una secuencia que no admite la funcionalidad invocada.");
            }
            catch (DirectoryNotFoundException)
            {
                stringBuilder.Append("No se pudo encontrar parte de un archivo o directorio.");
            }
            catch (PathTooLongException)
            {
                stringBuilder.Append("Una ruta o nombre de archivo es demasiado largo.");
            }
            catch (IOException)
            {
                stringBuilder.Append("Se ha producido un error de entrada/salida.");
            }
            catch (ArgumentNullException)
            {
                stringBuilder.Append("Se ha pasado una referencia nula a un método que no la acepta como argumento válido.");
            }
            catch (ArgumentException)
            {
                stringBuilder.Append("Uno de los argumentos proporcionados a un método no es válido.");
            }
            catch (System.Security.SecurityException)
            {
                stringBuilder.Append("Se ha detectado un error de seguridad.");
            }
            catch (Exception)
            {
                stringBuilder.Append("Ha ocurrido un error inesperado.");
            }

            error = stringBuilder.ToString();
        }

        public static List<Ejercito<string, string, string>> Leer(out string error)
        {
            string path;
            string datosEjercito;
            string aux;
            string[] arrayAux;
            int i = 0;
            Ejercito<string, string, string> ejercitoNuevo;
            List<Ejercito<string, string, string>> ejercitos = new List<Ejercito<string, string, string>>();
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                path = $"{Directory.GetCurrentDirectory()}\\Ejercitos.csv";

                using (StreamReader lector = new StreamReader(path))
                {
                    datosEjercito = lector.ReadToEnd();

                    while (i < datosEjercito.Length)
                    {
                        aux = "";

                        while (i < datosEjercito.Length)
                        {
                            if (datosEjercito[i] != '\n')
                            {
                                if (datosEjercito[i] == '\r')
                                {
                                    i++;
                                    continue;
                                }
                                else
                                {
                                    aux += datosEjercito[i];
                                    i++;
                                }
                            }
                            else if (aux != "ID;NOMBRE;NACION;TIPO;AUTONOMIA;CANTIDAD")
                            {
                                arrayAux = aux.Split(';');
                                ejercitoNuevo = new Ejercito<string, string, string>(int.Parse(arrayAux[0]), arrayAux[1], arrayAux[2], arrayAux[3], arrayAux[4], int.Parse(arrayAux[5]));
                                ejercitos.Add(ejercitoNuevo);
                                Ejercito<string, string, string>.IdEstatico++;
                                i++;
                                break;
                            }
                            else
                            {
                                i++;
                                break;
                            }
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                stringBuilder.Append("Usted no tiene autorización para acceder a esta ruta.");
            }
            catch (NotSupportedException)
            {
                stringBuilder.Append("Un método invocado no es compatible o se está intentando leer, buscar o escribir en una secuencia que no admite la funcionalidad invocada.");
            }
            catch (DirectoryNotFoundException)
            {
                stringBuilder.Append("No se pudo encontrar parte de un archivo o directorio.");
            }
            catch (FileNotFoundException)
            {
                stringBuilder.Append("Fallo al intentar acceder al archivo especificad, asegúrese de que el archivo existe en la ruta indicada");
            }
            catch (IOException)
            {
                stringBuilder.Append("Se ha producido un error de entrada/salida.");
            }
            catch (ArgumentNullException)
            {
                stringBuilder.Append("Se ha pasado una referencia nula a un método que no la acepta como argumento válido.");
            }
            catch (ArgumentException)
            {
                stringBuilder.Append("Uno de los argumentos proporcionados a un método no es válido.");
            }
            catch (Exception)
            {
                stringBuilder.Append("Ha ocurrido un error inesperado.");
            }

            error = stringBuilder.ToString();

            return ejercitos;
        }
    }
}
