using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Carga los componentes gráficos
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botón que cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Botón que limpia la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Justo antes de la ejecución limpia la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Establece algunos valores en vacíos o 0
        /// </summary>
        private void Limpiar()
        {
            this.lblResultado.Text = "0";
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
        }

        /// <summary>
        /// Parsea el operador, crea objetos de Operando y hace el cálculo entre ellos
        /// </summary>
        /// <param name="numero1">Primer número del cálculo</param>
        /// <param name="numero2">Segundo número del cálculo</param>
        /// <param name="operador">Operador del cálculo</param>
        /// <returns>Retorna el resultado del cálculo</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            char operadorChar;
            double retorno = 0;
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            if (char.TryParse(operador, out operadorChar))
            {
                retorno = Entidades.Calculadora.Operar(operando1, operando2, operadorChar);
            }

            return retorno;
        }

        /// <summary>
        /// Botón que convierte un número decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string numero;

            numero = this.lblResultado.Text;

            this.lblResultado.Text = Operando.DecimalBinario(numero);
        }

        /// <summary>
        /// Botón que convierte un número binario a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string binario;

            binario = this.lblResultado.Text;

            this.lblResultado.Text = Operando.BinarioDecimal(binario);
        }

        /// <summary>
        /// Botón que calcula la operación y muestra todas las operaciones hechas en la lista de operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string num1;
            string num2;
            string operador;
            double resultado;
            string resultadoStr;
            string mensajeError;

            num1 = this.txtNumero1.Text;
            num2 = this.txtNumero2.Text;
            operador = this.cmbOperador.Text;
            mensajeError = "Valor inválido";

            if (num1 != "0" && num1 != "1" && num1 != "2" && num1 != "3" && num1 != "4" && num1 != "5" && num1 != "6" && num1 != "7" && num1 != "8" && num1 != "9" ||
                num2 != "0" && num2 != "1" && num2 != "2" && num2 != "3" && num2 != "4" && num2 != "5" && num2 != "6" && num2 != "7" && num2 != "8" && num2 != "9")
            {
                this.lblResultado.Text = mensajeError;
            }
            else
            {
                resultado = Operar(num1, num2, operador);
                if (resultado == double.MinValue)
                {
                    this.lblResultado.Text = mensajeError;
                }
                else
                {
                    resultadoStr = resultado.ToString();
                    this.lblResultado.Text = resultadoStr;
                    this.lstOperaciones.Items.Add(num1 + " " + operador + " " + num2 + " = " + resultadoStr);
                }
            }
        }

        /// <summary>
        /// Cuando está empezando a cerrarse el formulario pregunta si realmente quiere salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
