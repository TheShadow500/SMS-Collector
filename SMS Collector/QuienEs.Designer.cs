namespace SMS_Collector
{
    partial class fr_QuienEs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_QuienEs));
            this.gb_DatosPersonales = new System.Windows.Forms.GroupBox();
            this.lb_Movil = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Apellidos = new System.Windows.Forms.Label();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.bt_Volver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_DatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_DatosPersonales
            // 
            this.gb_DatosPersonales.Controls.Add(this.lb_Movil);
            this.gb_DatosPersonales.Controls.Add(this.lb_Email);
            this.gb_DatosPersonales.Controls.Add(this.lb_Apellidos);
            this.gb_DatosPersonales.Controls.Add(this.lb_Nombre);
            this.gb_DatosPersonales.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DatosPersonales.ForeColor = System.Drawing.SystemColors.Window;
            this.gb_DatosPersonales.Location = new System.Drawing.Point(12, 12);
            this.gb_DatosPersonales.Name = "gb_DatosPersonales";
            this.gb_DatosPersonales.Size = new System.Drawing.Size(320, 126);
            this.gb_DatosPersonales.TabIndex = 0;
            this.gb_DatosPersonales.TabStop = false;
            this.gb_DatosPersonales.Text = "Información Detallada";
            // 
            // lb_Movil
            // 
            this.lb_Movil.AutoSize = true;
            this.lb_Movil.Location = new System.Drawing.Point(15, 93);
            this.lb_Movil.Name = "lb_Movil";
            this.lb_Movil.Size = new System.Drawing.Size(88, 17);
            this.lb_Movil.TabIndex = 3;
            this.lb_Movil.Text = "Nº de Móvil:";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(15, 71);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(53, 17);
            this.lb_Email.TabIndex = 2;
            this.lb_Email.Text = "e-Mail:";
            // 
            // lb_Apellidos
            // 
            this.lb_Apellidos.AutoSize = true;
            this.lb_Apellidos.Location = new System.Drawing.Point(15, 49);
            this.lb_Apellidos.Name = "lb_Apellidos";
            this.lb_Apellidos.Size = new System.Drawing.Size(72, 17);
            this.lb_Apellidos.TabIndex = 1;
            this.lb_Apellidos.Text = "Apellidos:";
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(15, 27);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(63, 17);
            this.lb_Nombre.TabIndex = 0;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // bt_Volver
            // 
            this.bt_Volver.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Volver.Location = new System.Drawing.Point(11, 146);
            this.bt_Volver.Name = "bt_Volver";
            this.bt_Volver.Size = new System.Drawing.Size(80, 23);
            this.bt_Volver.TabIndex = 1;
            this.bt_Volver.Text = "Volver";
            this.bt_Volver.UseVisualStyleBackColor = true;
            this.bt_Volver.Click += new System.EventHandler(this.bt_Volver_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(252, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fr_QuienEs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(344, 176);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Volver);
            this.Controls.Add(this.gb_DatosPersonales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fr_QuienEs";
            this.Text = "¿Quién es?";
            this.gb_DatosPersonales.ResumeLayout(false);
            this.gb_DatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_DatosPersonales;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Apellidos;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Button bt_Volver;
        private System.Windows.Forms.Label lb_Movil;
        private System.Windows.Forms.Button button1;
    }
}