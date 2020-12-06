
namespace FormPrincipal
{
    partial class frmHelicoptero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelicoptero));
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.numericCantPalas = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadPalas = new System.Windows.Forms.Label();
            this.numericTechoOperativo = new System.Windows.Forms.NumericUpDown();
            this.lblTechoOperativo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.textBoxNumSerie = new System.Windows.Forms.TextBox();
            this.lblDolares = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVelCrucero = new System.Windows.Forms.Label();
            this.textBoxVelCrucero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantPalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTechoOperativo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Location = new System.Drawing.Point(45, 35);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(236, 20);
            this.lblAdvertencia.TabIndex = 18;
            this.lblAdvertencia.Text = "LLENE TODAS LAS CASILLAS";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(237, 95);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 17;
            this.lblModelo.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(198, 118);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(100, 26);
            this.textBoxModelo.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(57, 95);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(10, 118);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(100, 26);
            this.textBoxMarca.TabIndex = 1;
            // 
            // numericCantPalas
            // 
            this.numericCantPalas.Location = new System.Drawing.Point(10, 239);
            this.numericCantPalas.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericCantPalas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericCantPalas.Name = "numericCantPalas";
            this.numericCantPalas.Size = new System.Drawing.Size(120, 26);
            this.numericCantPalas.TabIndex = 4;
            this.numericCantPalas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblCantidadPalas
            // 
            this.lblCantidadPalas.AutoSize = true;
            this.lblCantidadPalas.Location = new System.Drawing.Point(6, 216);
            this.lblCantidadPalas.Name = "lblCantidadPalas";
            this.lblCantidadPalas.Size = new System.Drawing.Size(141, 20);
            this.lblCantidadPalas.TabIndex = 20;
            this.lblCantidadPalas.Text = "Cantidad De Palas";
            // 
            // numericTechoOperativo
            // 
            this.numericTechoOperativo.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericTechoOperativo.Location = new System.Drawing.Point(178, 239);
            this.numericTechoOperativo.Maximum = new decimal(new int[] {
            42000,
            0,
            0,
            0});
            this.numericTechoOperativo.Minimum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.numericTechoOperativo.Name = "numericTechoOperativo";
            this.numericTechoOperativo.Size = new System.Drawing.Size(120, 26);
            this.numericTechoOperativo.TabIndex = 5;
            this.numericTechoOperativo.ThousandsSeparator = true;
            this.numericTechoOperativo.Value = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            // 
            // lblTechoOperativo
            // 
            this.lblTechoOperativo.AutoSize = true;
            this.lblTechoOperativo.Location = new System.Drawing.Point(173, 216);
            this.lblTechoOperativo.Name = "lblTechoOperativo";
            this.lblTechoOperativo.Size = new System.Drawing.Size(125, 20);
            this.lblTechoOperativo.TabIndex = 22;
            this.lblTechoOperativo.Text = "Techo Operativo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(103, 369);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 46);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Ingresar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Location = new System.Drawing.Point(174, 289);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(131, 20);
            this.lblNumSerie.TabIndex = 28;
            this.lblNumSerie.Text = "Numero De Serie";
            // 
            // textBoxNumSerie
            // 
            this.textBoxNumSerie.Location = new System.Drawing.Point(205, 312);
            this.textBoxNumSerie.Name = "textBoxNumSerie";
            this.textBoxNumSerie.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumSerie.TabIndex = 7;
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Location = new System.Drawing.Point(116, 318);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(41, 20);
            this.lblDolares.TabIndex = 26;
            this.lblDolares.Text = "U$S";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(57, 289);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 25;
            this.lblPrecio.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(10, 312);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 26);
            this.textBoxPrecio.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Knots";
            // 
            // lblVelCrucero
            // 
            this.lblVelCrucero.AutoSize = true;
            this.lblVelCrucero.Location = new System.Drawing.Point(83, 150);
            this.lblVelCrucero.Name = "lblVelCrucero";
            this.lblVelCrucero.Size = new System.Drawing.Size(139, 20);
            this.lblVelCrucero.TabIndex = 30;
            this.lblVelCrucero.Text = "Velocidad Crucero";
            // 
            // textBoxVelCrucero
            // 
            this.textBoxVelCrucero.Location = new System.Drawing.Point(87, 173);
            this.textBoxVelCrucero.Name = "textBoxVelCrucero";
            this.textBoxVelCrucero.Size = new System.Drawing.Size(100, 26);
            this.textBoxVelCrucero.TabIndex = 3;
            // 
            // frmHelicoptero
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormPrincipal.Properties.Resources.EMPANAJE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVelCrucero);
            this.Controls.Add(this.textBoxVelCrucero);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.textBoxNumSerie);
            this.Controls.Add(this.lblDolares);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTechoOperativo);
            this.Controls.Add(this.numericTechoOperativo);
            this.Controls.Add(this.lblCantidadPalas);
            this.Controls.Add(this.numericCantPalas);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.textBoxMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHelicoptero";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Helicoptero";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantPalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTechoOperativo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.NumericUpDown numericCantPalas;
        private System.Windows.Forms.Label lblCantidadPalas;
        private System.Windows.Forms.NumericUpDown numericTechoOperativo;
        private System.Windows.Forms.Label lblTechoOperativo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.TextBox textBoxNumSerie;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVelCrucero;
        private System.Windows.Forms.TextBox textBoxVelCrucero;
    }
}