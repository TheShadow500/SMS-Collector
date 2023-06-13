namespace SMS_Collector
{
    partial class fr_Verificacion3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Verificacion3));
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.bt_Volver = new System.Windows.Forms.Button();
            this.gb_UsuarioActual = new System.Windows.Forms.GroupBox();
            this.tb_Contraseña = new System.Windows.Forms.TextBox();
            this.lb_Contraseña = new System.Windows.Forms.Label();
            this.lb_Usuario2 = new System.Windows.Forms.Label();
            this.lb_Usuario1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_UsuarioActual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Aceptar.Location = new System.Drawing.Point(171, 159);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar.TabIndex = 10;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // bt_Volver
            // 
            this.bt_Volver.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Volver.Location = new System.Drawing.Point(21, 159);
            this.bt_Volver.Name = "bt_Volver";
            this.bt_Volver.Size = new System.Drawing.Size(75, 23);
            this.bt_Volver.TabIndex = 9;
            this.bt_Volver.Text = "Volver";
            this.bt_Volver.UseVisualStyleBackColor = true;
            this.bt_Volver.Click += new System.EventHandler(this.bt_Volver_Click);
            // 
            // gb_UsuarioActual
            // 
            this.gb_UsuarioActual.Controls.Add(this.tb_Contraseña);
            this.gb_UsuarioActual.Controls.Add(this.lb_Contraseña);
            this.gb_UsuarioActual.Controls.Add(this.lb_Usuario2);
            this.gb_UsuarioActual.Controls.Add(this.lb_Usuario1);
            this.gb_UsuarioActual.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_UsuarioActual.ForeColor = System.Drawing.SystemColors.Window;
            this.gb_UsuarioActual.Location = new System.Drawing.Point(21, 40);
            this.gb_UsuarioActual.Name = "gb_UsuarioActual";
            this.gb_UsuarioActual.Size = new System.Drawing.Size(225, 100);
            this.gb_UsuarioActual.TabIndex = 7;
            this.gb_UsuarioActual.TabStop = false;
            this.gb_UsuarioActual.Text = "Usuario Actual";
            // 
            // tb_Contraseña
            // 
            this.tb_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Contraseña.Location = new System.Drawing.Point(106, 59);
            this.tb_Contraseña.Name = "tb_Contraseña";
            this.tb_Contraseña.PasswordChar = '*';
            this.tb_Contraseña.Size = new System.Drawing.Size(96, 20);
            this.tb_Contraseña.TabIndex = 5;
            this.tb_Contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Contraseña_KeyPress);
            // 
            // lb_Contraseña
            // 
            this.lb_Contraseña.AutoSize = true;
            this.lb_Contraseña.Location = new System.Drawing.Point(18, 61);
            this.lb_Contraseña.Name = "lb_Contraseña";
            this.lb_Contraseña.Size = new System.Drawing.Size(82, 17);
            this.lb_Contraseña.TabIndex = 4;
            this.lb_Contraseña.Text = "Contraseña:";
            // 
            // lb_Usuario2
            // 
            this.lb_Usuario2.AutoSize = true;
            this.lb_Usuario2.Location = new System.Drawing.Point(103, 30);
            this.lb_Usuario2.Name = "lb_Usuario2";
            this.lb_Usuario2.Size = new System.Drawing.Size(57, 17);
            this.lb_Usuario2.TabIndex = 3;
            this.lb_Usuario2.Text = "Usuario";
            // 
            // lb_Usuario1
            // 
            this.lb_Usuario1.AutoSize = true;
            this.lb_Usuario1.Location = new System.Drawing.Point(18, 30);
            this.lb_Usuario1.Name = "lb_Usuario1";
            this.lb_Usuario1.Size = new System.Drawing.Size(61, 17);
            this.lb_Usuario1.TabIndex = 1;
            this.lb_Usuario1.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Por favor, introduzca la contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMS_Collector.Properties.Resources.Seguridad;
            this.pictureBox1.Location = new System.Drawing.Point(108, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // fr_Verificacion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(266, 202);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.bt_Volver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_UsuarioActual);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fr_Verificacion3";
            this.Text = "Autenticación de Usuario";
            this.gb_UsuarioActual.ResumeLayout(false);
            this.gb_UsuarioActual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Button bt_Volver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gb_UsuarioActual;
        private System.Windows.Forms.TextBox tb_Contraseña;
        private System.Windows.Forms.Label lb_Contraseña;
        private System.Windows.Forms.Label lb_Usuario2;
        private System.Windows.Forms.Label lb_Usuario1;
        private System.Windows.Forms.Label label1;
    }
}