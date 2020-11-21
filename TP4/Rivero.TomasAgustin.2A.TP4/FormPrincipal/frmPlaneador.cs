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

namespace FormPrincipal
{
    public partial class frmPlaneador : Form
    {
        public Planeador retorno;
        public frmPlaneador()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string marca = null;
            string modelo = null;
            int velCrucero = 0;
            double precio = 0;
            double numeroSerie = 0;
            double envergadura = 0;
            try
            {
                marca = this.textBoxMarca.Text;
                modelo = this.textBoxModelo.Text;
                precio = double.Parse(this.textBoxPrecio.Text);
                numeroSerie = double.Parse(this.textBoxNumSerie.Text);
                velCrucero = int.Parse(this.textBoxVelCrucero.Text);
                envergadura = double.Parse(this.textBoxEnvergadura.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            retorno = new Planeador(marca, modelo, velCrucero, precio, numeroSerie, envergadura);
        }
    }
}
