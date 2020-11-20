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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmSelectAeronave frmSeleccionAeronave = new frmSelectAeronave();

            frmSeleccionAeronave.Show();
            switch (frmSeleccionAeronave.DevComboBox())
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
        }
    }
}
