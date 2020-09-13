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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void BtOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            string op = this.Operadores.Text;
            Numero num1 = new Numero(this.Operador1.Text);
            Numero num2 = new Numero(this.Operador2.Text);

            resultado = Calcular.Operar(num1, num2, op);

            this.Resultado.Text = resultado.ToString();
        }

        private void BtABinario_Click(object sender, EventArgs e)
        {
            Numero num = new Numero();
            double numLabel = Convert.ToDouble(this.Resultado.Text);
            string binConvertido = num.DecimalBinario(numLabel);

            this.Resultado.Text = binConvertido;
        }

        private void BtADecimal_Click(object sender, EventArgs e)
        {
            Numero num = new Numero();
            string resultadoLabel = this.Resultado.Text;
            string binarioConvertido = num.BinarioDecimal(resultadoLabel);

            this.Resultado.Text = binarioConvertido;
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            this.Operador1.Text = "";
            this.Operador2.Text = "";
            this.Operadores.Text = "+";
            this.Resultado.Text = "";
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
