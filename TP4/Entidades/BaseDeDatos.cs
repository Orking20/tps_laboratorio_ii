using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class BaseDeDatos
    {
        static SqlConnection connection;
        static SqlCommand command;
        static SqlDataReader reader;

        /// <summary>
        /// Se conecta la base de datos, se instancia el command para que se puedan
        /// ejecutar las query y se asocia el command con la conexión ya establecida
        /// </summary>
        static BaseDeDatos()
        {
            connection = new SqlConnection("Data Source = ULTRON; Database = TP4_Luchetti_Capalbo_Mateo; Trusted_Connection = True;");
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
        }

        /// <summary>
        /// Recupera todos los datos cargados en la base de
        /// datos especificada y crea objetos de tipo Ejercito
        /// </summary>
        /// <param name="error">Mensaje de error</param>
        /// <returns></returns>
        public static List<Ejercito<string, string>> Select(out string error)
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<Ejercito<string, string>> listaEjercitos = new List<Ejercito<string, string>>();
         
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command.CommandText = "SELECT * FROM Ejercitos";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ejercito<string, string> ejercito = new Ejercito<string, string>();

                    ejercito.Id = (int)reader["ID"];
                    ejercito.Nombre = reader["NOMBRE"].ToString();
                    ejercito.Nacion = reader["NACION"].ToString();
                    ejercito.Tipo = reader["TIPO"].ToString();
                    ejercito.Autonomia = reader["AUTONOMIA"].ToString();
                    ejercito.CantMaxEjercito = (int)reader["CANTIDAD"];

                    listaEjercitos.Add(ejercito);
                    Ejercito<string, string>.IdEstatico = ejercito.Id;
                }
            }
            catch (Exception)
            {
                stringBuilder.Append("Hubo un problema al importar ciertos datos de la base de datos");
            }
            finally
            {
                error = stringBuilder.ToString();
                connection.Close();
            }
            
            return listaEjercitos;
        }

        /// <summary>
        /// Guarda los datos de un ejército en la base de datos
        /// </summary>
        /// <param name="ejercito">Ejército a guardar</param>
        /// <param name="error">Mensaje de error</param>
        public static void Insert(Ejercito<string, string> ejercito, out string error)
        {
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command.CommandText = "INSERT INTO Ejercitos VALUES (@ID, @NOMBRE, @NACION, @TIPO, @AUTONOMIA, @CANTIDAD)";
                
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@ID", ejercito.Id);
                command.Parameters.AddWithValue("@NOMBRE", ejercito.Nombre);
                command.Parameters.AddWithValue("@NACION", ejercito.Nacion);
                command.Parameters.AddWithValue("@TIPO", ejercito.Tipo);
                command.Parameters.AddWithValue("@AUTONOMIA", ejercito.Autonomia);
                command.Parameters.AddWithValue("@CANTIDAD", ejercito.CantMaxEjercito);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                stringBuilder.Append("Hubo un problema al exportar ciertos datos a la base de datos");
            }
            finally
            {
                error = stringBuilder.ToString();
                connection.Close();
            }
        }

        /// <summary>
        /// Elimina el ejército pasado por parametros de la base de datos
        /// </summary>
        /// <param name="ejercito">Ejército a eliminar</param>
        /// <param name="error">Mensaje de error</param>
        public static void Delete(Ejercito<string, string> ejercito, out string error)
        {
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command.CommandText = "DELETE FROM Ejercitos WHERE ID= @IDEJERCITO";

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@IDEJERCITO", ejercito.Id);
                
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                stringBuilder.Append("Hubo un problema al exportar ciertos datos a la base de datos");
            }
            finally
            {
                error = stringBuilder.ToString();
                connection.Close();
            }
        }

        /// <summary>
        /// Modifica el ejército pasado por parametros de la base de datos
        /// </summary>
        /// <param name="ejercito">Ejército a eliminar</param>
        /// <param name="nombre">Nombre a modificar</param>
        /// <param name="nacion">Nación a modificar</param>
        /// <param name="tipo">Tipo a modificar</param>
        /// <param name="autonomia">Autonomía a modificar</param>
        /// <param name="cantidad">Cantidad de tropas unitarias a modificar</param>
        /// <param name="error">Mensaje de error</param>
        public static void Update(Ejercito<string, string> ejercito, string nombre, string nacion, string tipo, string autonomia, string cantidad, out string error)
        {
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command.CommandText = "UPDATE Ejercitos SET NOMBRE = @NOMBRE, NACION = @NACION, TIPO = @TIPO, AUTONOMIA = @AUTONOMIA, CANTIDAD = @CANTIDAD WHERE ID = @IDEJERCITO";

                command.Parameters.Clear();

                command.Parameters.AddWithValue("@IDEJERCITO", ejercito.Id);
                command.Parameters.AddWithValue("@NOMBRE", nombre);
                command.Parameters.AddWithValue("@NACION", nacion);
                command.Parameters.AddWithValue("@TIPO", tipo);
                command.Parameters.AddWithValue("@AUTONOMIA", autonomia);
                command.Parameters.AddWithValue("@CANTIDAD", cantidad);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                stringBuilder.Append("Hubo un problema al exportar ciertos datos a la base de datos");
            }
            finally
            {
                error = stringBuilder.ToString();
                connection.Close();
            }
        }
    }
}
