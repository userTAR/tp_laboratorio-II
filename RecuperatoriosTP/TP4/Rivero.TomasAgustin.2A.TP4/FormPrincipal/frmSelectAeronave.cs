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
        
        /// <summary>
        /// Constructor que inicializa el indice seleccionado en 0
        /// </summary>
        public frmSelectAeronave()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
            this.cbSeleccion.SelectedIndex = 0;
        }

        
        /// <summary>
        /// Al apretar el boton aceptar, define el indice de la seleccion en la variable publica "eleccio"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.eleccion = this.cbSeleccion.SelectedIndex;
            this.Close();
        }
    }
}
