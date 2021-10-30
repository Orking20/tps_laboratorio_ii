using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operación pedida entre los números pasados como parámetros
        /// </summary>
        /// <param name="num1">Primer número recibido</param>
        /// <param name="num2">Segundo número recibido</param>
        /// <param name="operador">Operador que se va a usar para operar entre los dos números</param>
        /// <returns>Retorna el resultado</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double retorno = 0;

            switch (ValidarOperador(operador))
            {
                case '+':
                    retorno = num1 + num2;
                    break;

                case '-':
                    retorno = num1 - num2;
                    break;

                case '/':
                    retorno = num1 / num2;
                    break;

                case '*':
                    retorno = num1 * num2;
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Valida que el operador recibido sea '+', '-', '/' o '*'
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Retorna el operador ya validado o, caso contrario retorna '+'</returns>
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';

            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                retorno = operador;
            }

            return retorno;
        }
    }
}
