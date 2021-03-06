﻿using System;
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
    public partial class frmHelicoptero : Form
    {
        public Helicoptero retorno = null;
        public frmHelicoptero()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor del form que establece los valores inicales de los componentes
        /// </summary>
        /// <param name="helicop"></param>
        public frmHelicoptero(Helicoptero helicop)
        {
            InitializeComponent();
            this.textBoxMarca.Text = helicop.Marca;
            this.textBoxModelo.Text = helicop.Modelo;
            this.textBoxPrecio.Text = helicop.Precio.ToString();
            this.textBoxNumSerie.Text = helicop.NumeroDeSerie.ToString();
            this.textBoxVelCrucero.Text = helicop.VelocidadCrucero.ToString();
            this.numericCantPalas.Value = helicop.CantidadDePalas;
            this.numericTechoOperativo.Value = decimal.Parse(helicop.TechoOperativo.ToString());
        }

        /// <summary>
        /// Guarda todos los datos del formulario en la variable, al hacer click en el boton, para poder acceder la variable desde fuera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string marca = null;
            string modelo = null;
            int velCrucero = 0;
            double precio = 0;
            double numeroSerie = 0;
            int cantidadPalas = 0;
            double techoOperativo = 0;
            try
            {
                marca = this.textBoxMarca.Text;
                modelo = this.textBoxModelo.Text;
                precio = double.Parse(this.textBoxPrecio.Text);
                numeroSerie = double.Parse(this.textBoxNumSerie.Text);
                velCrucero = int.Parse(this.textBoxVelCrucero.Text);
                cantidadPalas = int.Parse(this.numericCantPalas.Value.ToString());
                techoOperativo = double.Parse(this.numericTechoOperativo.Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
                retorno = new Helicoptero(marca, modelo, velCrucero, precio, numeroSerie, cantidadPalas, techoOperativo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
