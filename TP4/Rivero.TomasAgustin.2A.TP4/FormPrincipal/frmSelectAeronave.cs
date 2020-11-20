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
        public frmSelectAeronave()
        {
            InitializeComponent();
        }

        public int DevComboBox()
        {
            int retorno;
            retorno = this.cbSeleccion.SelectedIndex;
            return retorno;
        }
    }
}
