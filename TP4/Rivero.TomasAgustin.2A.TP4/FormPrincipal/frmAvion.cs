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
    public partial class frmAvion : Form
    {
        public Avion retorno = null;
        public frmAvion()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor del form que establece los valores inicales de los componentes
        /// </summary>
        /// <param name="avion"></param>
        public frmAvion(Avion avion)
        {
            InitializeComponent();
            this.textBoxMarca.Text = avion.Marca;
            this.textBoxModelo.Text = avion.Modelo;
            this.textBoxAutonomia.Text = avion.Autonomia.ToString();
            this.textBoxVelPerdida.Text = avion.VelocidadDePerdida.ToString();
            this.textBoxEnvergadura.Text = avion.Envergadura.ToString();
            if (avion.TipoDePaso.ToString() == "Fijo")
                this.cbTipoPaso.SelectedIndex = 0;
            else
                this.cbTipoPaso.SelectedIndex = 1;
            this.textBoxPrecio.Text = avion.Precio.ToString();
            this.textBoxNumSerie.Text = avion.NumeroDeSerie.ToString();
            this.textBoxVelCrucero.Text = avion.VelocidadCrucero.ToString();
        }

        /// <summary>
        /// Guarda todos los datos del formulario en la variable, al hacer click en el boton, para poder acceder la variable desde fuera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            string marca = null;
            string modelo = null;
            int autonomia = 0;
            int Vs = 0;
            double envergadura = 0;
            double precio = 0;
            double numeroSerie = 0;
            int velCrucero = 0;
            Avion.EPaso paso = Avion.EPaso.Fijo;
            try
            {
                marca = this.textBoxMarca.Text;
                modelo = this.textBoxModelo.Text;
                autonomia = int.Parse(this.textBoxAutonomia.Text);
                Vs = int.Parse(this.textBoxVelPerdida.Text);
                envergadura = double.Parse(this.textBoxEnvergadura.Text);
                paso = (Avion.EPaso)this.cbTipoPaso.SelectedIndex;
                precio = double.Parse(this.textBoxPrecio.Text);
                numeroSerie = double.Parse(this.textBoxNumSerie.Text);
                velCrucero = int.Parse(this.textBoxVelCrucero.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
                retorno = new Avion(marca, modelo, velCrucero, Vs, precio, numeroSerie, paso, autonomia, envergadura);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
