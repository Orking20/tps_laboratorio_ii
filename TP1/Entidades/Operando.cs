using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        #region Propiedad
        /// <summary>
        /// Establece el valor de numero
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa numero en 0
        /// </summary>
        public Operando()
        {
            Numero = "0";
        }

        /// <summary>
        /// Inicializa numero con el valor pasado por parámetro
        /// </summary>
        /// <param name="numero">Nuevo valor para numero</param>
        public Operando(double numero)
        {
            Numero = numero.ToString();
        }

        /// <summary>
        /// Inicializa numero con el valor pasado por parámetro
        /// </summary>
        /// <param name="strNumero">Nuevo valor para numero</param>
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }
        #endregion

        #region Conversiones
        #region BinarioDecimal
        /// <summary>
        /// Convierte un número binario a decimal
        /// </summary>
        /// <param name="binario">Número a pasar a decimal</param>
        /// <returns>Retorna el número en decimal o, si no se puede: "Valor inválido"</returns>
        public static string BinarioDecimal(string binario)
        {
            string binarioAux = "";
            int potencia;
            double multiplicacion;
            string digitoStr;
            int digito;
            double acumulador = 0;
            string retorno = "Valor inválido";

            // Elimina la coma y todos los números que le sigan. Transforma los negativos en positivos
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != ',')
                {
                    if (binario[i] != '-')
                    {
                        binarioAux += binario[i];
                    }
                }
                else
                {
                    break;
                }
            }

            if (EsBinario(binarioAux))
            {
                for (int i = 0; i < binarioAux.Length; i++)
                {
                    digitoStr = binarioAux[i].ToString();
                    potencia = binarioAux.Length - i - 1;

                    if (int.TryParse(digitoStr, out digito))
                    {
                        multiplicacion = digito * Math.Pow(2, potencia);
                        acumulador += multiplicacion;
                        retorno = acumulador.ToString();
                    }
                    else
                    {
                        retorno = "Valor inválido";
                        break;
                    }
                }
            }

            return retorno;
        }
        #endregion

        #region DecimalBinario
        /// <summary>
        /// Convierte un número decimal a binario
        /// </summary>
        /// <param name="numero">Número a pasar a binario</param>
        /// <returns>Retorna el número en binario o, si no se puede: "Valor inválido"</returns>
        public static string DecimalBinario(double numero)
        {
            int numeroInt;
            string numeroStr;
            string numeroAux = "";
            string numeroBinario = "";
            string numeroBinarioConGuion = "";
            string numeroRetorno = "";

            // Elimina la coma y todos los números que le sigan
            numeroStr = numero.ToString();
            for (int i = 0; i < numeroStr.Length; i++)
            {
                if (numeroStr[i] != ',')
                {
                    if (numeroStr[i] != '-')
                    {
                        numeroAux += numeroStr[i];
                    }
                }
                else
                {
                    break;
                }
            }

            // Calculo de la parte entera binaria
            if (int.TryParse(numeroAux, out numeroInt))
            {
                while (numeroInt / 2 != 0)
                {
                    if (numeroInt % 2 == 1)
                    {
                        numeroBinario += "1";
                    }
                    else
                    {
                        numeroBinario += "0";
                    }

                    numeroInt /= 2;
                }

                if (numeroInt == 1)
                {
                    numeroBinario += "1";
                }

                // Completa con ceros el número binario solo si es necesario
                while (numeroBinario.Length % 4 != 0)
                {
                    numeroBinario += "0";
                }

                // Agrega un guión cada 4 números
                for (int i = 1; i <= numeroBinario.Length; i++)
                {
                    numeroBinarioConGuion += numeroBinario[i - 1];

                    if (i % 4 == 0 && i != numeroBinario.Length)
                    {
                        numeroBinarioConGuion += "-";
                    }
                }

                // Invierte la cadena para que tenga el número binario real
                foreach (char digito in numeroBinarioConGuion)
                {
                    numeroRetorno = digito + numeroRetorno;
                }

                for (int i = 0; i < numeroRetorno.Length; i++)
                {
                    if (numeroRetorno[i] != '1' && numeroRetorno[i] != '0' && numeroRetorno[i] != '-')
                    {
                        numeroRetorno = "Valor invalido";
                    }
                }
            }


            return numeroRetorno;
        }
        #endregion

        #region DecimalBinarioStr
        /// <summary>
        /// Convierte un número decimal a binario
        /// </summary>
        /// <param name="numero">Número a pasar a binario</param>
        /// <returns>Retorna el número en binario o, si no se puede: "Valor inválido"</returns>
        public static string DecimalBinario(string numero)
        {
            string retorno = "Valor inválido";
            double numeroAux;

            if (double.TryParse(numero, out numeroAux))
            {
                retorno = DecimalBinario(numeroAux);
            }

            return retorno;
        }
        #endregion
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Resta el numero del primer parametro con el del segundo parametro
        /// </summary>
        /// <param name="n1">Primer número</param>
        /// <param name="n2">Segundo número</param>
        /// <returns>Retorna la resta entre los dos números</returns>
        public static double operator - (Operando n1, Operando n2)
        {
            double retorno;

            retorno = n1.numero - n2.numero;

            return retorno;
        }

        /// <summary>
        /// Multiplica el numero del primer parametro con el del segundo parametro
        /// </summary>
        /// <param name="n1">Primer número</param>
        /// <param name="n2">Segundo número</param>
        /// <returns>Retorna la multiplicación entre los dos números</returns>
        public static double operator * (Operando n1, Operando n2)
        {
            double retorno;

            retorno = n1.numero * n2.numero;

            return retorno;
        }

        /// <summary>
        /// Divide el numero del primer parametro con el del segundo parametro
        /// </summary>
        /// <param name="n1">Primer número</param>
        /// <param name="n2">Segundo número</param>
        /// <returns>Retorna la división entre los dos números</returns>
        public static double operator / (Operando n1, Operando n2)
        {
            double retorno;

            if (n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }
            else
            {
                retorno = double.MinValue;
            }

            return retorno;
        }

        /// <summary>
        /// Suma el numero del primer parametro con el del segundo parametro
        /// </summary>
        /// <param name="n1">Primer número</param>
        /// <param name="n2">Segundo número</param>
        /// <returns>Retorna la suma entre los dos números</returns>
        public static double operator + (Operando n1, Operando n2)
        {
            double retorno;

            retorno = n1.numero + n2.numero;

            return retorno;
        }
        #endregion

        #region Métodos privados
        /// <summary>
        /// Valida que la cadena pasada por parametros contenga sólo caracteres '0' o '1'
        /// </summary>
        /// <param name="binario">String a ser validado</param>
        /// <returns>Retorna true si la cadena solo contiene caracteres '0' o '1' o false en caso contrario</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = false;

            foreach (char letra in binario)
            {
                if (letra == '0' || letra == '1')
                {
                    retorno = true;
                }
                else
                {
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Comprueba que el valor pasado por parámetro sea numérico
        /// </summary>
        /// <param name="strNumero">Valor a comprobar</param>
        /// <returns>Retorna el valor numérico decimal o, caso contrario un 0</returns>
        private double ValidarOperando(string strNumero) // Solo llamada por la propiedad Numero
        {
            double numero;

            if (!double.TryParse(strNumero, out numero))
            {
                numero = 0;
            }

            return numero;
        }
        #endregion
    }
}
