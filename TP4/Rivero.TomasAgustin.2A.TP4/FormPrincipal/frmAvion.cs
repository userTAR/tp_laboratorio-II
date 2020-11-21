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
        public Avion retorno;
        public frmAvion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Avion retorno = new Avion(marca,modelo,velCrucero,Vs,numeroSerie,paso,autonomia,envergadura);
        }
    }
}
