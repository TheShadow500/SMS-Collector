namespace SMS_Collector
{
    partial class fr_Preferencias
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Preferencias));
            this.gb_Preferencias = new System.Windows.Forms.GroupBox();
            this.tb_Anterior = new System.Windows.Forms.TextBox();
            this.lb_Anterior = new System.Windows.Forms.Label();
            this.tb_Contraseña = new System.Windows.Forms.TextBox();
            this.lb_Usuario = new System.Windows.Forms.Label();
            this.lb_Contraseña = new System.Windows.Forms.Label();
            this.tb_Usuario = new System.Windows.Forms.TextBox();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.bt_Volver = new System.Windows.Forms.Button();
            this.gb_Preferencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Preferencias
            // 
            this.gb_Preferencias.Controls.Add(this.tb_Anterior);
            this.gb_Preferencias.Controls.Add(this.lb_Anterior);
            this.gb_Preferencias.Controls.Add(this.tb_Contraseña);
            this.gb_Preferencias.Controls.Add(this.lb_Usuario);
            this.gb_Preferencias.Controls.Add(this.lb_Contraseña);
            this.gb_Preferencias.Controls.Add(this.tb_Usuario);
            this.gb_Preferencias.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Preferencias.ForeColor = System.Drawing.SystemColors.Window;
            this.gb_Preferencias.Location = new System.Drawing.Point(12, 12);
            this.gb_Preferencias.Name = "gb_Preferencias";
            this.gb_Preferencias.Size = new System.Drawing.Size(216, 118);
            this.gb_Preferencias.TabIndex = 0;
            this.gb_Preferencias.TabStop = false;
            this.gb_Preferencias.Text = "Preferencias";
            // 
            // tb_Anterior
            // 
            this.tb_Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Anterior.Location = new System.Drawing.Point(100, 80);
            this.tb_Anterior.Name = "tb_Anterior";
            this.tb_Anterior.PasswordChar = '*';
            this.tb_Anterior.Size = new System.Drawing.Size(100, 20);
            this.tb_Anterior.TabIndex = 6;
            // 
            // lb_Anterior
            // 
            this.lb_Anterior.AutoSize = true;
            this.lb_Anterior.Location = new System.Drawing.Point(12, 82);
            this.lb_Anterior.Name = "lb_Anterior";
            this.lb_Anterior.Size = new System.Drawing.Size(66, 17);
            this.lb_Anterior.TabIndex = 5;
            this.lb_Anterior.Text = "Anterior:";
            // 
            // tb_Contraseña
            // 
            this.tb_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Contraseña.Location = new System.Drawing.Point(100, 54);
            this.tb_Contraseña.Name = "tb_Contraseña";
            this.tb_Contraseña.PasswordChar = '*';
            this.tb_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.tb_Contraseña.TabIndex = 4;
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.AutoSize = true;
            this.lb_Usuario.Location = new System.Drawing.Point(12, 30);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(61, 17);
            this.lb_Usuario.TabIndex = 1;
            this.lb_Usuario.Text = "Usuario:";
            // 
            // lb_Contraseña
            // 
            this.lb_Contraseña.AutoSize = true;
            this.lb_Contraseña.Location = new System.Drawing.Point(12, 56);
            this.lb_Contraseña.Name = "lb_Contraseña";
            this.lb_Contraseña.Size = new System.Drawing.Size(82, 17);
            this.lb_Contraseña.TabIndex = 2;
            this.lb_Contraseña.Text = "Contraseña:";
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Usuario.Location = new System.Drawing.Point(100, 28);
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.Size = new System.Drawing.Size(100, 20);
            this.tb_Usuario.TabIndex = 3;
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Aceptar.Location = new System.Drawing.Point(153, 136);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar.TabIndex = 1;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // bt_Volver
            // 
            this.bt_Volver.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Volver.Location = new System.Drawing.Point(10, 135);
            this.bt_Volver.Name = "bt_Volver";
            this.bt_Volver.Size = new System.Drawing.Size(75, 23);
            this.bt_Volver.TabIndex = 2;
            this.bt_Volver.Text = "Volver";
            this.bt_Volver.UseVisualStyleBackColor = true;
            this.bt_Volver.Click += new System.EventHandler(this.bt_Volver_Click);
            // 
            // fr_Preferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(240, 166);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Volver);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.gb_Preferencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fr_Preferencias";
            this.Text = "Preferencias";
            this.gb_Preferencias.ResumeLayout(false);
            this.gb_Preferencias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Preferencias;
        private System.Windows.Forms.TextBox tb_Contraseña;
        private System.Windows.Forms.Label lb_Usuario;
        private System.Windows.Forms.TextBox tb_Usuario;
        private System.Windows.Forms.Label lb_Contraseña;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.TextBox tb_Anterior;
        private System.Windows.Forms.Label lb_Anterior;
        private System.Windows.Forms.Button bt_Volver;
    }
}