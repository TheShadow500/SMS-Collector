namespace SMS_Collector
{
    partial class fr_AñadirContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_AñadirContacto));
            this.gb_Detalles = new System.Windows.Forms.GroupBox();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_Apellidos = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Movil = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Apellidos = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.gb_Detalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Detalles
            // 
            this.gb_Detalles.Controls.Add(this.tb_Email);
            this.gb_Detalles.Controls.Add(this.tb_Apellidos);
            this.gb_Detalles.Controls.Add(this.tb_Nombre);
            this.gb_Detalles.Controls.Add(this.lb_Movil);
            this.gb_Detalles.Controls.Add(this.lb_Email);
            this.gb_Detalles.Controls.Add(this.lb_Apellidos);
            this.gb_Detalles.Controls.Add(this.lb_Nombre);
            this.gb_Detalles.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Detalles.ForeColor = System.Drawing.SystemColors.Window;
            this.gb_Detalles.Location = new System.Drawing.Point(12, 12);
            this.gb_Detalles.Name = "gb_Detalles";
            this.gb_Detalles.Size = new System.Drawing.Size(270, 149);
            this.gb_Detalles.TabIndex = 0;
            this.gb_Detalles.TabStop = false;
            this.gb_Detalles.Text = "Detalles Del Contacto";
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Guardar.Location = new System.Drawing.Point(207, 167);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_Guardar.TabIndex = 1;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancelar.Location = new System.Drawing.Point(12, 167);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancelar.TabIndex = 2;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(20, 32);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(63, 17);
            this.lb_Nombre.TabIndex = 0;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // lb_Apellidos
            // 
            this.lb_Apellidos.AutoSize = true;
            this.lb_Apellidos.Location = new System.Drawing.Point(20, 59);
            this.lb_Apellidos.Name = "lb_Apellidos";
            this.lb_Apellidos.Size = new System.Drawing.Size(72, 17);
            this.lb_Apellidos.TabIndex = 1;
            this.lb_Apellidos.Text = "Apellidos:";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(20, 86);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(53, 17);
            this.lb_Email.TabIndex = 2;
            this.lb_Email.Text = "e-Mail:";
            // 
            // lb_Movil
            // 
            this.lb_Movil.AutoSize = true;
            this.lb_Movil.Location = new System.Drawing.Point(20, 115);
            this.lb_Movil.Name = "lb_Movil";
            this.lb_Movil.Size = new System.Drawing.Size(88, 17);
            this.lb_Movil.TabIndex = 3;
            this.lb_Movil.Text = "Nº de Móvil:";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nombre.Location = new System.Drawing.Point(114, 28);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(134, 21);
            this.tb_Nombre.TabIndex = 4;
            // 
            // tb_Apellidos
            // 
            this.tb_Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Apellidos.Location = new System.Drawing.Point(114, 55);
            this.tb_Apellidos.Name = "tb_Apellidos";
            this.tb_Apellidos.Size = new System.Drawing.Size(134, 21);
            this.tb_Apellidos.TabIndex = 5;
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(114, 82);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(134, 21);
            this.tb_Email.TabIndex = 6;
            // 
            // fr_AñadirContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(294, 196);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.gb_Detalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fr_AñadirContacto";
            this.Text = "Añadir Nuevo Contacto";
            this.gb_Detalles.ResumeLayout(false);
            this.gb_Detalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Detalles;
        private System.Windows.Forms.Button bt_Guardar;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.Label lb_Movil;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Apellidos;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Apellidos;
        private System.Windows.Forms.TextBox tb_Nombre;
    }
}