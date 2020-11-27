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
        //-----------------------------
        Avion avion = new Avion();
        Helicoptero helicop = new Helicoptero();
        Planeador planeador = new Planeador();
        frmSelectAeronave frmSeleccionAeronave = new frmSelectAeronave();
        //----------------------------- 
        DataTable dt;
        SqlDataAdapter da = new SqlDataAdapter();
        SqlConnection cn;
        //-----------------------------
        #endregion

        public frmPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Invoca al formulario de seleccion, dependiendo de la seleccion invoca al formulario del objeto y agrega el objeto
        /// a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            frmAvion frmAvion = new frmAvion();
            frmHelicoptero frmHelicoptero = new frmHelicoptero(); 
            frmPlaneador frmPlaneador = new frmPlaneador(); 
            frmSeleccionAeronave.ShowDialog();
            if (frmSeleccionAeronave.DialogResult == DialogResult.OK)
            {
                // SWITCH DE FORMULARIO DE SELECCION
                switch (frmSeleccionAeronave.eleccion)
                {
                    case 0: // CASO AVION 
                        // SE CONFIGURA DA Y DT. SE MUESTRA EL FORM DE AVION, Y SE GUARDA EN LA BASE DE DATOS
                        if (!this.ConfigurarDataAdapterAvion(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }
                        try
                        {
                            this.ConfigurarDataTableAvion();
                            this.da.Fill(this.dt);
                            frmAvion.ShowDialog();
                            if (frmAvion.DialogResult == DialogResult.OK)
                            {
                                this.avion = frmAvion.retorno;
                                if (this.AgregadoABD(0))
                                    MessageBox.Show("AERONAVE AGREGADA A LA BASE DE DATOS");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        break;
                    case 1: //CASO HELICOPTERO
                        if (!this.ConfigurarDataAdapterHelicoptero(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }
                        try
                        {
                            this.ConfigurarDataTableHelicoptero();
                            this.da.Fill(this.dt);
                            frmHelicoptero.ShowDialog();
                            if (frmHelicoptero.DialogResult == DialogResult.OK)
                            {
                                this.helicop = frmHelicoptero.retorno;
                                if (this.AgregadoABD(1))
                                    MessageBox.Show("AERONAVE AGREGADA A LA BASE DE DATOS");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 2: // CASO PLANEADOR
                        if (!this.ConfigurarDataAdapterPlaneador(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }
                        try
                        {
                            this.ConfigurarDataTablePlaneador();
                            this.da.Fill(this.dt);
                            frmPlaneador.ShowDialog();
                            if (frmPlaneador.DialogResult == DialogResult.OK)
                            {
                                this.planeador = frmPlaneador.retorno;
                                if (this.AgregadoABD(2))
                                    MessageBox.Show("AERONAVE AGREGADA A LA BASE DE DATOS");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                }
               
            }
            
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            frmVisualizador frmVisualizador = new frmVisualizador();
            
            frmSeleccionAeronave.ShowDialog();
            if (frmSeleccionAeronave.DialogResult == DialogResult.OK)
            {
                switch (frmSeleccionAeronave.eleccion)
                {
                    case 0: // case avion
                        if (!this.ConfigurarDataAdapterAvion(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }
                        try
                        {
                            this.ConfigurarDataTableAvion();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                            if(frmVisualizador.DialogResult == DialogResult.OK)
                            {
                                this.dt.Rows[frmVisualizador.dgvGrilla.SelectedRows[0].Index].Delete();
                                this.da.Update(this.dt);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 1: // case helicoptero
                        if (!this.ConfigurarDataAdapterHelicoptero(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }

                        try
                        {
                            this.ConfigurarDataTableHelicoptero();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                            if (frmVisualizador.DialogResult == DialogResult.OK)
                            {
                                this.dt.Rows[frmVisualizador.dgvGrilla.SelectedRows[0].Index].Delete();
                                this.da.Update(this.dt);
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 2: //case planeador
                        if (!this.ConfigurarDataAdapterPlaneador(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }

                        try
                        {
                            this.ConfigurarDataTablePlaneador();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                            if (frmVisualizador.DialogResult == DialogResult.OK)
                            {
                                this.dt.Rows[frmVisualizador.dgvGrilla.SelectedRows[0].Index].Delete();
                                this.da.Update(this.dt);
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmVisualizador frmVisualizador = new frmVisualizador();

            frmSeleccionAeronave.ShowDialog();
            if (frmSeleccionAeronave.DialogResult == DialogResult.OK)
            {
                
                switch (frmSeleccionAeronave.eleccion)
                {
                    case 0: // case avion
                        if (!this.ConfigurarDataAdapterAvion(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }
                        try
                        {
                            this.ConfigurarDataTableAvion();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                            if (frmVisualizador.DialogResult == DialogResult.OK)
                            {
                                this.Modificado(0, frmVisualizador);
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 1: // case helicoptero
                        if (!this.ConfigurarDataAdapterHelicoptero(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }
                        try
                        {
                            this.ConfigurarDataTableHelicoptero();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                            if (frmVisualizador.DialogResult == DialogResult.OK)
                            {
                                this.Modificado(1, frmVisualizador);
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 2: //case planeador
                        if (!this.ConfigurarDataAdapterPlaneador(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }
                        try
                        {
                            this.ConfigurarDataTablePlaneador();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                            if (frmVisualizador.DialogResult == DialogResult.OK)
                            {
                                this.Modificado(2, frmVisualizador);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                }

            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            frmVisualizador frmVisualizador = new frmVisualizador();
            int index = 0;
            frmSeleccionAeronave.ShowDialog();
            if (frmSeleccionAeronave.DialogResult == DialogResult.OK)
            {

                switch (frmSeleccionAeronave.eleccion)
                {
                    case 0:
                        if (!this.ConfigurarDataAdapterAvion(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }
                        try
                        {
                            this.ConfigurarDataTableAvion();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                            if (frmVisualizador.DialogResult == DialogResult.OK)
                            {
                                index = frmVisualizador.dgvGrilla.SelectedRows[0].Index;
                                this.AvionFromGrilla(this.dt, index);
                                this.dt.Rows[index].Delete(); 
                                this.da.Update(this.dt);
                            }
                            if (!this.ConfigurarDataAdapterAvion(Properties.Settings.Default.aeronavesVendidas))
                            {
                                MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                                this.Close();
                            }
                            if (this.AgregadoABD(0))
                            {
                                MessageBox.Show("AERONAVE VENDIDA");
                                MessageBox.Show("AERONAVE AGREGADA A LA BASE DE DATOS DE LOS VENDIDOS");
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 1:
                        if (!this.ConfigurarDataAdapterHelicoptero(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }
                        try
                        {
                            this.ConfigurarDataTableHelicoptero();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                            if (frmVisualizador.DialogResult == DialogResult.OK)
                            {
                                index = frmVisualizador.dgvGrilla.SelectedRows[0].Index;
                                this.HelicopteroFromGrilla(this.dt, index);
                                this.dt.Rows[index].Delete();
                                this.da.Update(this.dt);
                            }
                            if (!this.ConfigurarDataAdapterHelicoptero(Properties.Settings.Default.aeronavesVendidas))
                            {
                                MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                                this.Close();
                            }
                            if (this.AgregadoABD(1))
                            {
                                MessageBox.Show("AERONAVE VENDIDA");
                                MessageBox.Show("AERONAVE AGREGADA A LA BASE DE DATOS DE LOS VENDIDOS");
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 2:
                         if (!this.ConfigurarDataAdapterPlaneador(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }
                        try
                        {
                            this.ConfigurarDataTablePlaneador();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                            if (frmVisualizador.DialogResult == DialogResult.OK)
                            {
                                index = frmVisualizador.dgvGrilla.SelectedRows[0].Index;
                                this.PlaneadorFromGrilla(this.dt, index);
                                this.dt.Rows[index].Delete(); 
                                this.da.Update(this.dt);
                            }
                            if (!this.ConfigurarDataAdapterPlaneador(Properties.Settings.Default.aeronavesVendidas))
                            {
                                MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                                this.Close();
                            }
                            if (this.AgregadoABD(2))
                            {
                                MessageBox.Show("AERONAVE VENDIDA");
                                MessageBox.Show("AERONAVE AGREGADA A LA BASE DE DATOS DE LOS VENDIDOS");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                }
            }
        }
        
        private void btnVendidos_Click(object sender, EventArgs e) //visualizar vendidos de un mismo tipo
        {
            frmVisualizador frmVisualizador = new frmVisualizador();

            frmSeleccionAeronave.ShowDialog();
            if (frmSeleccionAeronave.DialogResult == DialogResult.OK)
            {
                switch (frmSeleccionAeronave.eleccion)
                {
                    case 0: // case avion
                        if (!this.ConfigurarDataAdapterAvion(Properties.Settings.Default.aeronavesVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }

                        try
                        {
                            this.ConfigurarDataTableAvion();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 1: // case helicoptero
                        if (!this.ConfigurarDataAdapterHelicoptero(Properties.Settings.Default.aeronavesVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }

                        try
                        {
                            this.ConfigurarDataTableHelicoptero();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 2: //case planeador
                        if (!this.ConfigurarDataAdapterPlaneador(Properties.Settings.Default.aeronavesVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }
                        try
                        {
                            this.ConfigurarDataTablePlaneador();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                }

            }
        }

        private void btnBBDD_Click(object sender, EventArgs e) //visualizar todas las aeronaves de un mismo tipo
        {
            frmVisualizador frmVisualizador = new frmVisualizador();

            frmSeleccionAeronave.ShowDialog();
            if (frmSeleccionAeronave.DialogResult == DialogResult.OK)
            {
                
                switch (frmSeleccionAeronave.eleccion)
                {
                    case 0: // case avion
                        if (!this.ConfigurarDataAdapterAvion(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }

                        try
                        {
                            this.ConfigurarDataTableAvion();
                            
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 1: // case helicoptero
                        if (!this.ConfigurarDataAdapterHelicoptero(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }

                        try
                        {
                            this.ConfigurarDataTableHelicoptero();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case 2: //case planeador
                        if (!this.ConfigurarDataAdapterPlaneador(Properties.Settings.Default.aeronavesNoVendidas))
                        {
                            MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
                            this.Close();
                        }

                        try
                        {
                            this.ConfigurarDataTablePlaneador();
                            this.da.Fill(this.dt);

                            frmVisualizador.dgvGrilla.DataSource = this.dt;
                            frmVisualizador.ShowDialog();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        break;
                }

            }
        }


        #region configuracion de DT Y DA

        #region DA Y DT Avion
        private bool ConfigurarDataAdapterAvion(string SQLconnectionPath)
        {
            bool rta = false;
            
            try
            {
                this.cn = new SqlConnection(SQLconnectionPath);

                this.da = new SqlDataAdapter();

                this.da.SelectCommand = new SqlCommand("SELECT marca, modelo, velocidadCrucero, velocidadPerdida, precio, numeroSerie, tipoPaso, autonomia, envergadura FROM dbo.avion", cn);
                this.da.InsertCommand = new SqlCommand("INSERT INTO dbo.avion (marca, modelo, velocidadCrucero, velocidadPerdida, precio, numeroSerie, tipoPaso, autonomia, envergadura) VALUES (@marca, @modelo, @velocidadCrucero, @velocidadPerdida, @precio, @numeroSerie, @tipoPaso, @autonomia, @envergadura)", cn);
                this.da.UpdateCommand = new SqlCommand("UPDATE dbo.avion SET marca=@marca, modelo=@modelo, velocidadCrucero=@velocidadCrucero, velocidadPerdida=@velocidadPerdida, precio=@precio, numeroSerie=@numeroSerie, tipoPaso=@tipoPaso, autonomia=@autonomia, envergadura=@envergadura WHERE numeroSerie=@numeroSerie", cn);
                this.da.DeleteCommand = new SqlCommand("DELETE FROM dbo.avion WHERE numeroSerie=@numeroSerie", cn);

                this.da.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.InsertCommand.Parameters.Add("@modelo", SqlDbType.VarChar, 50, "modelo");
                this.da.InsertCommand.Parameters.Add("@velocidadCrucero", SqlDbType.Int, 10, "velocidadCrucero");
                this.da.InsertCommand.Parameters.Add("@velocidadPerdida", SqlDbType.Int, 10, "velocidadPerdida");
                this.da.InsertCommand.Parameters.Add("@precio", SqlDbType.VarChar, 50, "precio");
                this.da.InsertCommand.Parameters.Add("@numeroSerie", SqlDbType.VarChar, 50, "numeroSerie");
                this.da.InsertCommand.Parameters.Add("@tipoPaso", SqlDbType.VarChar, 50, "tipopaso");
                this.da.InsertCommand.Parameters.Add("@autonomia", SqlDbType.Int, 10, "autonomia");
                this.da.InsertCommand.Parameters.Add("@envergadura", SqlDbType.VarChar, 50, "envergadura");


                this.da.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.UpdateCommand.Parameters.Add("@modelo", SqlDbType.VarChar, 50, "modelo");
                this.da.UpdateCommand.Parameters.Add("@velocidadCrucero", SqlDbType.Int, 10, "velocidadCrucero");
                this.da.UpdateCommand.Parameters.Add("@velocidadPerdida", SqlDbType.Int, 10, "velocidadPerdida");
                this.da.UpdateCommand.Parameters.Add("@precio", SqlDbType.VarChar, 50, "precio");
                this.da.UpdateCommand.Parameters.Add("@numeroSerie", SqlDbType.VarChar, 50, "numeroSerie");
                this.da.UpdateCommand.Parameters.Add("@tipoPaso", SqlDbType.VarChar, 50, "tipopaso");
                this.da.UpdateCommand.Parameters.Add("@autonomia", SqlDbType.Int, 10, "autonomia");
                this.da.UpdateCommand.Parameters.Add("@envergadura", SqlDbType.VarChar, 50, "envergadura");

                this.da.DeleteCommand.Parameters.Add("@numeroSerie", SqlDbType.VarChar, 50, "numeroSerie");

                rta = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return rta;
        }
        private void ConfigurarDataTableAvion()
        {
            this.dt = new DataTable("Avion");

            this.dt.Columns.Add("marca", typeof(string));
            this.dt.Columns.Add("modelo", typeof(string));
            this.dt.Columns.Add("velocidadCrucero", typeof(int));
            this.dt.Columns.Add("precio", typeof(string));
            this.dt.Columns.Add("numeroSerie", typeof(string));
            this.dt.Columns.Add("tipoPaso", typeof(string));
            this.dt.Columns.Add("autonomia", typeof(int));
            this.dt.Columns.Add("envergadura", typeof(string));

        }
        #endregion

        #region DA Y DT helicoptero
        private bool ConfigurarDataAdapterHelicoptero(string SQLconnectionPath)
        {
            bool rta = false;
            //Properties.Settings.Default.
            try
            {
                SqlConnection cn = new SqlConnection(SQLconnectionPath);

                this.da = new SqlDataAdapter();

                this.da.SelectCommand = new SqlCommand("SELECT marca, modelo, velocidadCrucero, precio, numeroSerie, cantidadPalas, techoOperativo FROM dbo.helicoptero", cn);
                this.da.InsertCommand = new SqlCommand("INSERT INTO dbo.helicoptero (marca, modelo, velocidadCrucero, precio, numeroSerie, cantidadPalas, techoOperativo) VALUES (@marca, @modelo, @velocidadCrucero, @precio, @numeroSerie, @cantidadPalas, @techoOperativo)", cn);
                this.da.UpdateCommand = new SqlCommand("UPDATE dbo.helicoptero SET marca=@marca, modelo=@modelo, velocidadCrucero=@velocidadCrucero, precio=@precio, numeroSerie=@numeroSerie, cantidadPalas=@cantidadPalas, techoOperativo=@techoOperativo WHERE numeroSerie=@numeroSerie", cn);
                this.da.DeleteCommand = new SqlCommand("DELETE FROM dbo.helicoptero WHERE numeroSerie=@numeroSerie", cn);

                this.da.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.InsertCommand.Parameters.Add("@modelo", SqlDbType.VarChar, 50, "modelo");
                this.da.InsertCommand.Parameters.Add("@velocidadCrucero", SqlDbType.Int, 10, "velocidadCrucero");
                this.da.InsertCommand.Parameters.Add("@precio", SqlDbType.VarChar, 50, "precio");
                this.da.InsertCommand.Parameters.Add("@numeroSerie", SqlDbType.VarChar, 50, "numeroSerie");
                this.da.InsertCommand.Parameters.Add("@cantidadPalas", SqlDbType.Int, 10, "cantidadPalas");
                this.da.InsertCommand.Parameters.Add("@techoOperativo", SqlDbType.VarChar, 50, "techoOperativo");


                this.da.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.UpdateCommand.Parameters.Add("@modelo", SqlDbType.VarChar, 50, "modelo");
                this.da.UpdateCommand.Parameters.Add("@velocidadCrucero", SqlDbType.Int, 10, "velocidadCrucero");
                this.da.UpdateCommand.Parameters.Add("@precio", SqlDbType.VarChar, 50, "precio");
                this.da.UpdateCommand.Parameters.Add("@numeroSerie", SqlDbType.VarChar, 50, "numeroSerie");
                this.da.UpdateCommand.Parameters.Add("@cantidadPalas", SqlDbType.Int, 10, "cantidadPalas");
                this.da.UpdateCommand.Parameters.Add("@techoOperativo", SqlDbType.VarChar, 50, "techoOperativo");

                this.da.DeleteCommand.Parameters.Add("@numeroSerie", SqlDbType.VarChar, 50, "numeroSerie");

                rta = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return rta;
        }
        private void ConfigurarDataTableHelicoptero()
        {
            this.dt = new DataTable("Helicoptero");

            this.dt.Columns.Add("marca", typeof(string));
            this.dt.Columns.Add("modelo", typeof(string));
            this.dt.Columns.Add("velocidadCrucero", typeof(int));
            this.dt.Columns.Add("precio", typeof(string));
            this.dt.Columns.Add("numeroSerie", typeof(string));
            this.dt.Columns.Add("cantidadPalas", typeof(int));
            this.dt.Columns.Add("techoOperativo", typeof(string));

        }
        #endregion

        #region DA Y DT planeador
        private bool ConfigurarDataAdapterPlaneador(string SQLconnectionPath)
        {
            bool rta = false;
            //Properties.Settings.Default.
            try
            {
                SqlConnection cn = new SqlConnection(SQLconnectionPath);

                this.da = new SqlDataAdapter();

                this.da.SelectCommand = new SqlCommand("SELECT marca, modelo, velocidadCrucero, precio, numeroSerie, envergadura FROM dbo.planeador", cn);
                this.da.InsertCommand = new SqlCommand("INSERT INTO dbo.planeador (marca, modelo, velocidadCrucero, precio, numeroSerie, envergadura) VALUES (@marca, @modelo, @velocidadCrucero, @precio, @numeroSerie, @envergadura)", cn);
                this.da.UpdateCommand = new SqlCommand("UPDATE dbo.planeador SET marca=@marca, modelo=@modelo, velocidadCrucero=@velocidadCrucero, precio=@precio, numeroSerie=@numeroSerie, envergadura=@envergadura WHERE numeroSerie=@numeroSerie", cn);
                this.da.DeleteCommand = new SqlCommand("DELETE FROM dbo.planeador WHERE numeroSerie=@numeroSerie", cn);

                this.da.InsertCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.InsertCommand.Parameters.Add("@modelo", SqlDbType.VarChar, 50, "modelo");
                this.da.InsertCommand.Parameters.Add("@velocidadCrucero", SqlDbType.Int, 10, "velocidadCrucero");
                this.da.InsertCommand.Parameters.Add("@precio", SqlDbType.VarChar, 50, "precio");
                this.da.InsertCommand.Parameters.Add("@numeroSerie", SqlDbType.VarChar, 50, "numeroSerie");
                this.da.InsertCommand.Parameters.Add("@envergadura", SqlDbType.VarChar, 50, "envergadura");
                
                this.da.UpdateCommand.Parameters.Add("@marca", SqlDbType.VarChar, 50, "marca");
                this.da.UpdateCommand.Parameters.Add("@modelo", SqlDbType.VarChar, 50, "modelo");
                this.da.UpdateCommand.Parameters.Add("@velocidadCrucero", SqlDbType.Int, 10, "velocidadCrucero");
                this.da.UpdateCommand.Parameters.Add("@precio", SqlDbType.VarChar, 50, "precio");
                this.da.UpdateCommand.Parameters.Add("@numeroSerie", SqlDbType.VarChar, 50, "numeroSerie");
                this.da.UpdateCommand.Parameters.Add("@envergadura", SqlDbType.VarChar, 50, "envergadura");

                this.da.DeleteCommand.Parameters.Add("@numeroSerie", SqlDbType.VarChar, 50, "numeroSerie");

                rta = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return rta;
        }
        private void ConfigurarDataTablePlaneador()
        {
            this.dt = new DataTable("Planeador");

            this.dt.Columns.Add("marca", typeof(string));
            this.dt.Columns.Add("modelo", typeof(string));
            this.dt.Columns.Add("velocidadCrucero", typeof(int));
            this.dt.Columns.Add("precio", typeof(string));
            this.dt.Columns.Add("numeroSerie", typeof(string));
            this.dt.Columns.Add("envergadura", typeof(string));
        }
        #endregion

        #endregion

        #region metodos

        /// <summary>
        /// Se encarga de sobreescribir las filas con la información del objeto según la elección que hagamos
        /// </summary>
        /// <param name="eleccion"></param>
        /// <param name="fila"></param>
        private bool AgregadoABD(int eleccion)
        {
            bool retorno = true;
            DataRow fila = this.dt.NewRow();

            switch (eleccion)
            {
                case 0:
                    fila["marca"] = this.avion.Marca;
                    fila["modelo"] = this.avion.Modelo;
                    fila["velocidadCrucero"] = this.avion.VelocidadCrucero;
                    fila["velocidadPerdida"] = this.avion.VelocidadDePerdida;
                    fila["precio"] = this.avion.Precio;
                    fila["numeroSerie"] = this.avion.NumeroDeSerie;
                    fila["tipoPaso"] = this.avion.TipoDePaso.ToString();
                    fila["autonomia"] = this.avion.Autonomia;
                    fila["envergadura"] = this.avion.Envergadura;

                    this.dt.Rows.Add(fila);
                    try
                    {
                        this.da.Update(this.dt);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        retorno = false;
                    }
                    break;
                case 1:
                    fila["marca"] = this.helicop.Marca;
                    fila["modelo"] = this.helicop.Modelo;
                    fila["velocidadCrucero"] = this.helicop.VelocidadCrucero;
                    fila["precio"] = this.helicop.Precio;
                    fila["numeroSerie"] = this.helicop.NumeroDeSerie;
                    fila["cantidadPalas"] = this.helicop.CantidadDePalas;
                    fila["techoOperativo"] = this.helicop.TechoOperativo;

                    this.dt.Rows.Add(fila);
                    try
                    {
                        this.da.Update(this.dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        retorno = false;
                    }
                    break;
                case 2:
                    fila["marca"] = this.planeador.Marca;
                    fila["modelo"] = this.planeador.Modelo;
                    fila["velocidadCrucero"] = this.planeador.VelocidadCrucero;
                    fila["precio"] = this.planeador.Precio;
                    fila["numeroSerie"] = this.planeador.NumeroDeSerie;
                    fila["envergadura"] = this.planeador.Envergadura;

                    this.dt.Rows.Add(fila);
                    try
                    {
                        this.da.Update(this.dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        retorno = false;
                    }
                    break;
            }
            return retorno;
        }
        
        /// <summary>
        /// Según la elección, se encarga de crear una nueva fila, llenarla con los datos del objeto y actualizar la base de datos
        /// NOTA: LOS DATATABLE DEBEN SER CONFIGURADOS ANTES SEGÚN LA ELECCIÓN
        /// </summary>
        /// <param name="eleccion"></param>
        /// <param name="dt"></param>
        /// <param name="index"></param>
        private bool ActualizadoABD(int eleccion, DataTable dt, int index)
        {
            DataRow fila = this.dt.Rows[index];
            bool retorno = true;
            switch (eleccion)
            {
                case 0:
                    fila["marca"] = this.avion.Marca;
                    fila["modelo"] = this.avion.Modelo;
                    fila["velocidadCrucero"] = this.avion.VelocidadCrucero;
                    fila["velocidadPerdida"] = this.avion.VelocidadDePerdida;
                    fila["precio"] = this.avion.Precio;
                    fila["numeroSerie"] = this.avion.NumeroDeSerie;
                    fila["tipoPaso"] = this.avion.TipoDePaso;
                    fila["autonomia"] = this.avion.Autonomia;
                    fila["envergadura"] = this.avion.Envergadura;
                    try
                    {
                        this.da.Update(this.dt);
                    }
                    catch(Exception ex)
                    {
                        retorno = false;
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 1:
                    fila["marca"] = this.helicop.Marca;
                    fila["modelo"] = this.helicop.Modelo;
                    fila["velocidadCrucero"] = this.helicop.VelocidadCrucero;
                    fila["precio"] = this.helicop.Precio;
                    fila["numeroSerie"] = this.helicop.NumeroDeSerie;
                    fila["cantidadPalas"] = this.helicop.CantidadDePalas;
                    fila["techoOperativo"] = this.helicop.TechoOperativo;

                    try
                    {
                        this.da.Update(this.dt);
                    }
                    catch (Exception ex)
                    {
                        retorno = false;
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 2:
                    fila["marca"] = this.planeador.Marca;
                    fila["modelo"] = this.planeador.Modelo;
                    fila["velocidadCrucero"] = this.planeador.VelocidadCrucero;
                    fila["precio"] = this.planeador.Precio;
                    fila["numeroSerie"] = this.planeador.NumeroDeSerie;
                    fila["envergadura"] = this.planeador.Envergadura;

                    try
                    {
                        this.da.Update(this.dt);
                    }
                    catch (Exception ex)
                    {
                        retorno = false;
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
            return retorno;
        }

        /// <summary>
        /// Trae los datos de la fila seleccionada, crea un nuevo objeto y se lo pasa a ActualizadoABD
        /// </summary>
        /// <param name="eleccion"></param>
        /// <param name="form"></param>
        private void Modificado(int eleccion, frmVisualizador form)
        {
            int index = form.dgvGrilla.SelectedRows[0].Index;
            frmAvion frmAvion;
            frmHelicoptero frmHelicoptero;
            frmPlaneador frmPlaneador;
            switch (eleccion)
            {
                case 0: // avion
                    if(form.DialogResult == DialogResult.OK)
                    {
                        // TRAE LOS DATOS
                        this.AvionFromGrilla(this.dt, index); //suceptible a excepcion (sin controlar)
                        // GENERA UN NUEVO FORM DE AVION PARA PERMITIR MODIFICAR LOS DATOS
                        frmAvion = new frmAvion(this.avion);
                        frmAvion.ShowDialog();
                        if(frmAvion.DialogResult == DialogResult.OK)
                        {
                            this.avion = frmAvion.retorno;
                            //ACTUALIZA LOS DATOS DE LA FILA SEGUN LO INGRESADO Y LOS SUBE A LA BASE DE DATOS
                            if (this.ActualizadoABD(0, this.dt, index))
                                MessageBox.Show("AERONAVE ACTUALIZADA CORRECTAMENTE");
                        }

                    }
                    break;
                case 1: // helicoptero

                    if (form.DialogResult == DialogResult.OK)
                    {
                        this.HelicopteroFromGrilla(this.dt, index); //suceptible a excepcion (sin controlar)
                        frmHelicoptero = new frmHelicoptero(this.helicop);
                        frmHelicoptero.ShowDialog();
                        if (frmHelicoptero.DialogResult == DialogResult.OK)
                        {
                            this.helicop = frmHelicoptero.retorno;
                            if (this.ActualizadoABD(1, this.dt, index))
                                MessageBox.Show("AERONAVE ACTUALIZADA CORRECTAMENTE");
                        }

                    }
                    break;
                case 2: // planeador
                    if (form.DialogResult == DialogResult.OK)
                    {
                        this.PlaneadorFromGrilla(this.dt, index); //suceptible a excepcion (sin controlar)
                        frmPlaneador = new frmPlaneador(this.planeador);
                        frmPlaneador.ShowDialog();
                        if (frmPlaneador.DialogResult == DialogResult.OK)
                        {
                            this.planeador = frmPlaneador.retorno;
                            if (this.ActualizadoABD(2, this.dt, index))
                                MessageBox.Show("AERONAVE ACTUALIZADA CORRECTAMENTE");
                        }

                    }
                    break;
            }
        }
       
        #region objetos desde la grilla
        private void AvionFromGrilla(DataTable dt, int index)
        {
            DataRow fila = this.dt.Rows[index];

            this.avion.Marca = fila["marca"].ToString();
            this.avion.Modelo = fila["modelo"].ToString();
            this.avion.VelocidadCrucero = int.Parse(fila["velocidadCrucero"].ToString());
            this.avion.VelocidadDePerdida = int.Parse(fila["velocidadPerdida"].ToString());
            this.avion.Precio = double.Parse(fila["precio"].ToString());
            this.avion.NumeroDeSerie = double.Parse(fila["numeroSerie"].ToString());
            //this.avion.TipoDePaso = fila["tipoPaso"].ToString();          
            this.avion.Autonomia = int.Parse(fila["autonomia"].ToString());
            this.avion.Envergadura = double.Parse(fila["envergadura"].ToString());

        }
        private void HelicopteroFromGrilla(DataTable dt, int index)
        {
            DataRow fila = this.dt.Rows[index];

            this.helicop.Marca = fila["marca"].ToString();
            this.helicop.Modelo = fila["modelo"].ToString();
            this.helicop.VelocidadCrucero = int.Parse(fila["velocidadCrucero"].ToString());
            this.helicop.Precio = double.Parse(fila["precio"].ToString());
            this.helicop.NumeroDeSerie = double.Parse(fila["numeroSerie"].ToString());
            this.helicop.CantidadDePalas = int.Parse(fila["cantidadPalas"].ToString());
            this.helicop.TechoOperativo = double.Parse(fila["techoOperativo"].ToString());

        }
        private void PlaneadorFromGrilla(DataTable dt, int index)
        {
            DataRow fila = this.dt.Rows[index];

            this.planeador.Marca = fila["marca"].ToString();
            this.planeador.Modelo = fila["modelo"].ToString();
            this.planeador.VelocidadCrucero = int.Parse(fila["velocidadCrucero"].ToString());
            this.planeador.Precio = double.Parse(fila["precio"].ToString());
            this.planeador.NumeroDeSerie = double.Parse(fila["numeroSerie"].ToString());
            this.planeador.Envergadura = double.Parse(fila["envergadura"].ToString());
        }
        #endregion

        #endregion

    }
}
