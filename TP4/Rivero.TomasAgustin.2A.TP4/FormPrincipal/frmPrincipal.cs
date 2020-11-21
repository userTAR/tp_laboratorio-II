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
using System.Data.SqlClient;

namespace FormPrincipal
{
    public partial class frmPrincipal : Form
    {
        #region atributos
        Avion avion = new Avion();
        Helicoptero helicop = new Helicoptero();
        Planeador planeador = new Planeador();
        DataTable dataTable;
        SqlDataAdapter dataAdapter;
        SqlConnection connection;
        #endregion

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmSelectAeronave frmSeleccionAeronave = new frmSelectAeronave();
            frmAvion frmAvion = new frmAvion();
            frmHelicoptero frmHelicoptero = new frmHelicoptero(); 
            frmPlaneador frmPlaneador = new frmPlaneador(); 
            frmSeleccionAeronave.ShowDialog();
            if (frmSeleccionAeronave.DialogResult == DialogResult.OK)
            {
                if (frmSeleccionAeronave.eleccion == 0) // avion
                {
                    frmAvion.ShowDialog();
                    avion = frmAvion.retorno;
                }
                else if (frmSeleccionAeronave.eleccion == 1) // helicoptero
                {
                    frmHelicoptero.ShowDialog();
                    helicop = frmHelicoptero.retorno;
                }
                else if (frmSeleccionAeronave.eleccion == 2) // planeador
                {
                    frmPlaneador.ShowDialog();
                    planeador = frmPlaneador.retorno;
                }
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {

        }

        private void btnVendidos_Click(object sender, EventArgs e)
        {

        }

        private void btnBBDD_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualTodas_Click(object sender, EventArgs e)
        {

        }
    }
}
