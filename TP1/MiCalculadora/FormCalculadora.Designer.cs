namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.BtOperar = new System.Windows.Forms.Button();
            this.BtCerrar = new System.Windows.Forms.Button();
            this.BtABinario = new System.Windows.Forms.Button();
            this.BtLimpiar = new System.Windows.Forms.Button();
            this.BtADecimal = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.Operador2 = new System.Windows.Forms.TextBox();
            this.Operadores = new System.Windows.Forms.ComboBox();
            this.Operador1 = new System.Windows.Forms.TextBox();
            this.Num1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtOperar
            // 
            this.BtOperar.Location = new System.Drawing.Point(63, 239);
            this.BtOperar.Name = "BtOperar";
            this.BtOperar.Size = new System.Drawing.Size(123, 50);
            this.BtOperar.TabIndex = 3;
            this.BtOperar.Text = "Operar";
            this.BtOperar.UseVisualStyleBackColor = true;
            this.BtOperar.Click += new System.EventHandler(this.BtOperar_Click);
            // 
            // BtCerrar
            // 
            this.BtCerrar.AutoSize = true;
            this.BtCerrar.Location = new System.Drawing.Point(586, 239);
            this.BtCerrar.Name = "BtCerrar";
            this.BtCerrar.Size = new System.Drawing.Size(123, 50);
            this.BtCerrar.TabIndex = 5;
            this.BtCerrar.Text = "Cerrar";
            this.BtCerrar.UseVisualStyleBackColor = true;
            this.BtCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // BtABinario
            // 
            this.BtABinario.Location = new System.Drawing.Point(52, 351);
            this.BtABinario.Name = "BtABinario";
            this.BtABinario.Size = new System.Drawing.Size(355, 50);
            this.BtABinario.TabIndex = 6;
            this.BtABinario.Text = "Convertir a Binario";
            this.BtABinario.UseVisualStyleBackColor = true;
            this.BtABinario.Click += new System.EventHandler(this.BtABinario_Click);
            // 
            // BtLimpiar
            // 
            this.BtLimpiar.Location = new System.Drawing.Point(320, 239);
            this.BtLimpiar.Name = "BtLimpiar";
            this.BtLimpiar.Size = new System.Drawing.Size(123, 50);
            this.BtLimpiar.TabIndex = 7;
            this.BtLimpiar.Text = "Limpiar";
            this.BtLimpiar.UseVisualStyleBackColor = true;
            this.BtLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // BtADecimal
            // 
            this.BtADecimal.Location = new System.Drawing.Point(423, 351);
            this.BtADecimal.Name = "BtADecimal";
            this.BtADecimal.Size = new System.Drawing.Size(296, 50);
            this.BtADecimal.TabIndex = 8;
            this.BtADecimal.Text = "Convertir a Decimal";
            this.BtADecimal.UseVisualStyleBackColor = true;
            this.BtADecimal.Click += new System.EventHandler(this.BtADecimal_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Resultado.Location = new System.Drawing.Point(553, 146);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(2, 22);
            this.Resultado.TabIndex = 9;
            this.Resultado.Tag = "resultado";
            // 
            // Operador2
            // 
            this.Operador2.BackColor = System.Drawing.SystemColors.Control;
            this.Operador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Operador2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Operador2.Location = new System.Drawing.Point(553, 101);
            this.Operador2.Name = "Operador2";
            this.Operador2.Size = new System.Drawing.Size(145, 26);
            this.Operador2.TabIndex = 2;
            this.Operador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Operadores
            // 
            this.Operadores.AllowDrop = true;
            this.Operadores.BackColor = System.Drawing.SystemColors.Control;
            this.Operadores.DisplayMember = "+";
            this.Operadores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Operadores.FormattingEnabled = true;
            this.Operadores.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.Operadores.Location = new System.Drawing.Point(320, 100);
            this.Operadores.Name = "Operadores";
            this.Operadores.Size = new System.Drawing.Size(121, 28);
            this.Operadores.TabIndex = 1;
            // 
            // Operador1
            // 
            this.Operador1.BackColor = System.Drawing.SystemColors.Control;
            this.Operador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Operador1.Location = new System.Drawing.Point(52, 102);
            this.Operador1.Name = "Operador1";
            this.Operador1.Size = new System.Drawing.Size(145, 26);
            this.Operador1.TabIndex = 0;
            this.Operador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Location = new System.Drawing.Point(48, 67);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(185, 20);
            this.Num1.TabIndex = 10;
            this.Num1.Text = "Ingrese el primer número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingrese el operando";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Location = new System.Drawing.Point(549, 69);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(203, 20);
            this.Num2.TabIndex = 12;
            this.Num2.Text = "Ingrese el segundo número";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(461, 148);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(86, 20);
            this.Result.TabIndex = 13;
            this.Result.Text = "Resultado:";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Operador2);
            this.Controls.Add(this.Operadores);
            this.Controls.Add(this.Operador1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.BtADecimal);
            this.Controls.Add(this.BtLimpiar);
            this.Controls.Add(this.BtABinario);
            this.Controls.Add(this.BtCerrar);
            this.Controls.Add(this.BtOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.Text = "Calculadora de Tomás Agustín Rivero 2°A";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtOperar;
        private System.Windows.Forms.Button BtCerrar;
        private System.Windows.Forms.Button BtABinario;
        private System.Windows.Forms.Button BtLimpiar;
        private System.Windows.Forms.Button BtADecimal;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox Operador2;
        private System.Windows.Forms.ComboBox Operadores;
        private System.Windows.Forms.TextBox Operador1;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Result;
    }
}

