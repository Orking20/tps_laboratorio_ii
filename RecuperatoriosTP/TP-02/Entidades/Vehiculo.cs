using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        EMarca marca;
        string chasis;
        ConsoleColor color;

        /// <summary>
        /// Inicializa las variables del vehículo
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Vehiculo(EMarca marca, string chasis, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }

        /// <summary>
        /// Indica la marca del vehículo
        /// </summary>
        public enum EMarca
        {
            Chevrolet,
            Ford,
            Renault,
            Toyota,
            BMW,
            Honda,
            HarleyDavidson
        }

        /// <summary>
        /// Indica el tamaño del vehículo
        /// </summary>
        public enum ETamanio
        {
            Chico,
            Mediano,
            Grande
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Sobrecargo el string para que devuelva un string con algunas
        /// características de un vehículo
        /// </summary>
        /// <param name="vehiculo"></param>
        public static explicit operator string (Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", vehiculo.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", vehiculo.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", vehiculo.color.ToString());
            sb.AppendLine("---------------------\n");
            sb.AppendFormat("TAMAÑO : {0}", vehiculo.Tamanio);

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="vehiculo1"></param>
        /// <param name="vehiculo2"></param>
        /// <returns></returns>
        public static bool operator == (Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return vehiculo1.chasis == vehiculo2.chasis;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="vehiculo1"></param>
        /// <param name="vehiculo2"></param>
        /// <returns></returns>
        public static bool operator != (Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return vehiculo1.chasis != vehiculo2.chasis;
        }
    }
}
