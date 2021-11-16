using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Archivo
    {
        /// <summary>
        /// Guarda los datos de todos los ejercitos almacenados en la lista pasada por parametro en un archivo .csv
        /// </summary>
        /// <param name="ejercitos">Lista con todos los ejercitos a guardar</param>
        /// <param name="nombreArchivo">Nombre del archivo donde se guardaran los datos</param>
        /// <param name="error">Cadena donde se almacenará el error ocurrido, si es que hay error</param>
        public static void EscribirCsv(List<Ejercito<string, string>> ejercitos, string nombreArchivo, out string error)
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

                using (StreamWriter escritor = new StreamWriter(Path.Combine(path, nombreArchivo)))
                {
                    escritor.WriteLine("ID;NOMBRE;NACION;TIPO;AUTONOMIA;CANTIDAD");

                    for (int i = 0; i < ejercitos.Count; i++)
                    {
                        escritor.WriteLine($"{ejercitos[i].Id};{ejercitos[i].Nombre};{ejercitos[i].Nacion};{ejercitos[i].Tipo};{ejercitos[i].Autonomia};{ejercitos[i].CantMaxEjercito}");

                        Ejercito<string, string>.IdEstatico++;
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                stringBuilder.Append("Usted no tiene autorización para acceder a esta ruta.");
            }
            catch (DirectoryNotFoundException)
            {
                stringBuilder.Append("No se pudo encontrar parte de un archivo o directorio.");
            }
            catch (PathTooLongException)
            {
                stringBuilder.Append("Una ruta o nombre de archivo es demasiado largo.");
            }
            catch (Exception)
            {
                stringBuilder.Append("Ha ocurrido un error al exportar el archivo.");
            }

            error = stringBuilder.ToString();
        }

        /// <summary>
        /// Obtiene los datos del archivo "Ejercitos.csv" y los almacena en una lista
        /// </summary>
        /// <param name="error">Cadena donde se almacenará el error ocurrido, si es que hay error</param>
        /// <returns>Retorna la lista donde se encuentran los datos obtenidos</returns>
        public static List<Ejercito<string, string>> LeerCsv(string nombreArchivo, out string error)
        {
            string path;
            string datosEjercito;
            string aux;
            string[] arrayAux;
            int i = 0;
            Ejercito<string, string> ejercitoNuevo;
            List<Ejercito<string, string>> ejercitos = new List<Ejercito<string, string>>();
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                path = Path.Combine(Directory.GetCurrentDirectory(), nombreArchivo);

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
                                ejercitoNuevo = new Ejercito<string, string>(int.Parse(arrayAux[0]), arrayAux[1], arrayAux[2], arrayAux[3], arrayAux[4], int.Parse(arrayAux[5]));
                                ejercitos.Add(ejercitoNuevo);
                                Ejercito<string, string>.IdEstatico++;
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
            catch (DirectoryNotFoundException)
            {
                stringBuilder.Append("No se pudo encontrar parte de un archivo o directorio.");
            }
            catch (FileNotFoundException)
            {
                stringBuilder.Append("Fallo al intentar acceder al archivo especificado, asegúrese de que el archivo existe en la ruta indicada.");
            }
            catch (FormatException)
            {
                stringBuilder.Append("Hubo un error al intentar pasar un número a texto.\nAsegúrese de que los datos en el archivo están bien cargados");
            }
            catch (OverflowException)
            {
                stringBuilder.Append("Hubo un desbordamiento de algún número.\nAsegúrese de que los datos en el archivo están bien cargados");
            }
            catch (Exception)
            {
                stringBuilder.Append("Ha ocurrido un error al importar el archivo.");
            }

            error = stringBuilder.ToString();

            return ejercitos;
        }

        /// <summary>
        /// Guarda los datos de todos los ejercitos almacenados en la lista pasada por parametro en un archivo .xml
        /// </summary>
        /// <param name="ejercitos">Lista con todos los ejercitos a guardar</param>
        /// <param name="error">Cadena donde se almacenará el error ocurrido, si es que hay error</param>
        public static void EscribirXml(List<Ejercito<string, string>> ejercitos, out string error)
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

                using (XmlTextWriter escritor = new XmlTextWriter($"{path}\\EjercitosXml.xml", Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Ejercito<string, string>>));
                    serializer.Serialize(escritor, ejercitos);

                    foreach (Ejercito<string, string> ejercito in ejercitos)
                    {
                        Ejercito<string, string>.IdEstatico++;
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                stringBuilder.Append("Usted no tiene autorización para acceder a esta ruta.");
            }
            catch (DirectoryNotFoundException)
            {
                stringBuilder.Append("No se pudo encontrar parte de un archivo o directorio.");
            }
            catch (PathTooLongException)
            {
                stringBuilder.Append("Una ruta o nombre de archivo es demasiado largo.");
            }
            catch (Exception)
            {
                stringBuilder.Append("Ha ocurrido un error al exportar el archivo.");
            }

            error = stringBuilder.ToString();
        }

        /// <summary>
        /// Obtiene los datos del archivo "Ejercitos.xml" y los almacena en una lista
        /// </summary>
        /// <param name="error">Cadena donde se almacenará el error ocurrido, si es que hay error</param>
        /// <returns>Retorna la lista donde se encuentran los datos obtenidos</returns>
        public static List<Ejercito<string, string>> LeerXml(out string error)
        {
            string path;
            List<Ejercito<string, string>> ejercitos = new List<Ejercito<string, string>>();
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                path = Path.Combine(Directory.GetCurrentDirectory(), "EjercitosXml.xml");

                using (XmlTextReader lector = new XmlTextReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Ejercito<string, string>>));

                    ejercitos = (List<Ejercito<string, string>>)serializer.Deserialize(lector);

                    foreach (Ejercito<string, string> ejercito in ejercitos)
                    {
                        Ejercito<string, string>.IdEstatico = ejercito.Id;
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                stringBuilder.Append("Usted no tiene autorización para acceder a esta ruta.");
            }
            catch (DirectoryNotFoundException)
            {
                stringBuilder.Append("No se pudo encontrar parte de un archivo o directorio.");
            }
            catch (FileNotFoundException)
            {
                stringBuilder.Append("Fallo al intentar acceder al archivo especificado, asegúrese de que el archivo existe en la ruta indicada.");
            }
            catch (FormatException)
            {
                stringBuilder.Append("Hubo un error al intentar pasar un número a texto.\nAsegúrese de que los datos en el archivo están bien cargados");
            }
            catch (OverflowException)
            {
                stringBuilder.Append("Hubo un desbordamiento de algún número.\nAsegúrese de que los datos en el archivo están bien cargados");
            }
            catch (Exception)
            {
                stringBuilder.Append("Ha ocurrido un error al importar el archivo.");
            }

            error = stringBuilder.ToString();

            return ejercitos;
        }

        /// <summary>
        /// Guarda los datos de todos los ejercitos almacenados en la lista pasada por parametro en un archivo .json
        /// </summary>
        /// <param name="ejercitos">Lista con todos los ejercitos a guardar</param>
        /// <param name="error">Cadena donde se almacenará el error ocurrido, si es que hay error</param>
        public static void EscribirJson(List<Ejercito<string, string>> ejercitos, out string error)
        {
            string path;
            string textoSerializado;
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                path = Directory.GetCurrentDirectory();

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;

                textoSerializado = JsonSerializer.Serialize(ejercitos, opciones);
                File.WriteAllText($"{path}\\EjercitosJson.json", textoSerializado);

                foreach (Ejercito<string, string> ejercito in ejercitos)
                {
                    Ejercito<string, string>.IdEstatico++;
                }
            }
            catch (UnauthorizedAccessException)
            {
                stringBuilder.Append("Usted no tiene autorización para acceder a esta ruta.");
            }
            catch (DirectoryNotFoundException)
            {
                stringBuilder.Append("No se pudo encontrar parte de un archivo o directorio.");
            }
            catch (PathTooLongException)
            {
                stringBuilder.Append("Una ruta o nombre de archivo es demasiado largo.");
            }
            catch (Exception)
            {
                stringBuilder.Append("Ha ocurrido un error al exportar el archivo.");
            }

            error = stringBuilder.ToString();
        }

        /// <summary>
        /// Obtiene los datos del archivo "Ejercitos.json" y los almacena en una lista
        /// </summary>
        /// <param name="error">Cadena donde se almacenará el error ocurrido, si es que hay error</param>
        /// <returns>Retorna la lista donde se encuentran los datos obtenidos</returns>
        public static List<Ejercito<string, string>> LeerJson(out string error)
        {
            string path;
            string infoArchivo;
            List<Ejercito<string, string>> ejercitos = new List<Ejercito<string, string>>();
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                path = Directory.GetCurrentDirectory();

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                infoArchivo = File.ReadAllText($"{path}\\EjercitosJson.json");

                ejercitos = JsonSerializer.Deserialize<List<Ejercito<string, string>>>(infoArchivo);

                foreach (Ejercito<string, string> ejercito in ejercitos)
                {
                    Ejercito<string, string>.IdEstatico = ejercito.Id;
                }
            }
            catch (UnauthorizedAccessException)
            {
                stringBuilder.Append("Usted no tiene autorización para acceder a esta ruta.");
            }
            catch (DirectoryNotFoundException)
            {
                stringBuilder.Append("No se pudo encontrar parte de un archivo o directorio.");
            }
            catch (FileNotFoundException)
            {
                stringBuilder.Append("Fallo al intentar acceder al archivo especificado, asegúrese de que el archivo existe en la ruta indicada.");
            }
            catch (FormatException)
            {
                stringBuilder.Append("Hubo un error al intentar pasar un número a texto.\nAsegúrese de que los datos en el archivo están bien cargados");
            }
            catch (OverflowException)
            {
                stringBuilder.Append("Hubo un desbordamiento de algún número.\nAsegúrese de que los datos en el archivo están bien cargados");
            }
            catch (Exception)
            {
                stringBuilder.Append("Ha ocurrido un error al importar el archivo.");
            }

            error = stringBuilder.ToString();

            return ejercitos;
        }

        /// <summary>
        /// Guarda el porcentaje de el criterio pasado por parametro en un archivo .csv
        /// </summary>
        /// <param name="criterio">Texto donde especifica el criterio con el cual se saca el porcentaje</param>
        /// <param name="porcentaje">Porcentaje sacado a partir del criterio</param>
        /// <param name="nombreArchivo">Nombre del archivo donde se guardaran los datos</param>
        /// <param name="error">Cadena donde se almacenará el error ocurrido, si es que hay error</param> 
        public static void EscribirPorcentajes(string criterio, float porcentaje, string nombreArchivo, out string error)
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

                using (StreamWriter escritor = new StreamWriter(Path.Combine(path, nombreArchivo)))
                {
                    escritor.WriteLine("CRITERIO;PORCENTAJE");
                    escritor.WriteLine($"{criterio};{porcentaje}");
                }
            }
            catch (UnauthorizedAccessException)
            {
                stringBuilder.Append("Usted no tiene autorización para acceder a esta ruta.");
            }
            catch (DirectoryNotFoundException)
            {
                stringBuilder.Append("No se pudo encontrar parte de un archivo o directorio.");
            }
            catch (PathTooLongException)
            {
                stringBuilder.Append("Una ruta o nombre de archivo es demasiado largo.");
            }
            catch (Exception)
            {
                stringBuilder.Append("Ha ocurrido un error al exportar el archivo.");
            }

            error = stringBuilder.ToString();
        }
    }
}
