
namespace FormPrincipal
{
    partial class frmPlaneador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaneador));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.lblMetros = new System.Windows.Forms.Label();
            this.lblEnvergadura = new System.Windows.Forms.Label();
            this.textBoxEnvergadura = new System.Windows.Forms.TextBox();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.textBoxNumSerie = new System.Windows.Forms.TextBox();
            this.lblDolares = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.lblKnots = new System.Windows.Forms.Label();
            this.lblVelCrucero = new System.Windows.Forms.Label();
            this.textBoxVelCrucero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(101, 392);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 46);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "Ingresar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Location = new System.Drawing.Point(46, 55);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(236, 20);
            this.lblAdvertencia.TabIndex = 28;
            this.lblAdvertencia.Text = "LLENE TODAS LAS CASILLAS";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(238, 115);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 27;
            this.lblModelo.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(199, 138);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(100, 26);
            this.textBoxModelo.TabIndex = 26;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(58, 115);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 25;
            this.lblMarca.Text = "Marca";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(11, 138);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(100, 26);
            this.textBoxMarca.TabIndex = 24;
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(209, 206);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(35, 20);
            this.lblMetros.TabIndex = 32;
            this.lblMetros.Text = "Mts";
            // 
            // lblEnvergadura
            // 
            this.lblEnvergadura.AutoSize = true;
            this.lblEnvergadura.Location = new System.Drawing.Point(103, 177);
            this.lblEnvergadura.Name = "lblEnvergadura";
            this.lblEnvergadura.Size = new System.Drawing.Size(100, 20);
            this.lblEnvergadura.TabIndex = 31;
            this.lblEnvergadura.Text = "Envergadura";
            // 
            // textBoxEnvergadura
            // 
            this.textBoxEnvergadura.Location = new System.Drawing.Point(103, 200);
            this.textBoxEnvergadura.Name = "textBoxEnvergadura";
            this.textBoxEnvergadura.Size = new System.Drawing.Size(100, 26);
            this.textBoxEnvergadura.TabIndex = 30;
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Location = new System.Drawing.Point(168, 308);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(131, 20);
            this.lblNumSerie.TabIndex = 37;
            this.lblNumSerie.Text = "Numero De Serie";
            // 
            // textBoxNumSerie
            // 
            this.textBoxNumSerie.Location = new System.Drawing.Point(199, 331);
            this.textBoxNumSerie.Name = "textBoxNumSerie";
            this.textBoxNumSerie.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumSerie.TabIndex = 36;
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Location = new System.Drawing.Point(110, 337);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(41, 20);
            this.lblDolares.TabIndex = 35;
            this.lblDolares.Text = "U$S";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(51, 308);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 34;
            this.lblPrecio.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(4, 331);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 26);
            this.textBoxPrecio.TabIndex = 33;
            // 
            // lblKnots
            // 
            this.lblKnots.AutoSize = true;
            this.lblKnots.Location = new System.Drawing.Point(209, 270);
            this.lblKnots.Name = "lblKnots";
            this.lblKnots.Size = new System.Drawing.Size(50, 20);
            this.lblKnots.TabIndex = 40;
            this.lblKnots.Text = "Knots";
            // 
            // lblVelCrucero
            // 
            this.lblVelCrucero.AutoSize = true;
            this.lblVelCrucero.Location = new System.Drawing.Point(99, 241);
            this.lblVelCrucero.Name = "lblVelCrucero";
            this.lblVelCrucero.Size = new System.Drawing.Size(139, 20);
            this.lblVelCrucero.TabIndex = 39;
            this.lblVelCrucero.Text = "Velocidad Crucero";
            // 
            // textBoxVelCrucero
            // 
            this.textBoxVelCrucero.Location = new System.Drawing.Point(103, 264);
            this.textBoxVelCrucero.Name = "textBoxVelCrucero";
            this.textBoxVelCrucero.Size = new System.Drawing.Size(100, 26);
            this.textBoxVelCrucero.TabIndex = 38;
            // 
            // frmPlaneador
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormPrincipal.Properties.Resources._20190928_180608;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.lblKnots);
            this.Controls.Add(this.lblVelCrucero);
            this.Controls.Add(this.textBoxVelCrucero);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.textBoxNumSerie);
            this.Controls.Add(this.lblDolares);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.lblEnvergadura);
            this.Controls.Add(this.textBoxEnvergadura);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.textBoxMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlaneador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Planeador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Label lblEnvergadura;
        private System.Windows.Forms.TextBox textBoxEnvergadura;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.TextBox textBoxNumSerie;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label lblKnots;
        private System.Windows.Forms.Label lblVelCrucero;
        private System.Windows.Forms.TextBox textBoxVelCrucero;
    }
}