
namespace FormPrincipal
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVendidos = new System.Windows.Forms.Button();
            this.btnBBDD = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(37, 567);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 59);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Aeronave";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(222, 567);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 59);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar Aeronave";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(403, 567);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 59);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar Aeronave";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVendidos
            // 
            this.btnVendidos.Location = new System.Drawing.Point(747, 562);
            this.btnVendidos.Name = "btnVendidos";
            this.btnVendidos.Size = new System.Drawing.Size(94, 69);
            this.btnVendidos.TabIndex = 3;
            this.btnVendidos.Text = "Visualizar Vendidos";
            this.btnVendidos.UseVisualStyleBackColor = true;
            this.btnVendidos.Click += new System.EventHandler(this.btnVendidos_Click);
            // 
            // btnBBDD
            // 
            this.btnBBDD.Location = new System.Drawing.Point(908, 562);
            this.btnBBDD.Name = "btnBBDD";
            this.btnBBDD.Size = new System.Drawing.Size(99, 69);
            this.btnBBDD.TabIndex = 4;
            this.btnBBDD.Text = "Visualizar Aeronaves";
            this.btnBBDD.UseVisualStyleBackColor = true;
            this.btnBBDD.Click += new System.EventHandler(this.btnBBDD_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(582, 562);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(87, 69);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "Vender Una Aeronave";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // frmPrincipal
            // 
            this.AccessibleName = "Formulario de inicio";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormPrincipal.Properties.Resources._738_puntoDeEspera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 685);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnBBDD);
            this.Controls.Add(this.btnVendidos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVendidos;
        private System.Windows.Forms.Button btnBBDD;
        private System.Windows.Forms.Button btnVender;
    }
}

