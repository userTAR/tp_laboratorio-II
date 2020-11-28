using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class frmSelectAeronave : Form
    {
        public int eleccion;
        public frmSelectAeronave()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
            this.cbSeleccion.SelectedIndex = 0;
        }

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.eleccion = this.cbSeleccion.SelectedIndex;
            this.Close();
        }
    }
}
