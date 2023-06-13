namespace SMS_Collector
{
    partial class fr_Intentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Intentos));
            this.list_Intentos = new System.Windows.Forms.ListBox();
            this.bt_Volver = new System.Windows.Forms.Button();
            this.bt_Borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_Intentos
            // 
            this.list_Intentos.FormattingEnabled = true;
            this.list_Intentos.Location = new System.Drawing.Point(12, 12);
            this.list_Intentos.Name = "list_Intentos";
            this.list_Intentos.Size = new System.Drawing.Size(332, 147);
            this.list_Intentos.TabIndex = 0;
            // 
            // bt_Volver
            // 
            this.bt_Volver.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Volver.Location = new System.Drawing.Point(12, 165);
            this.bt_Volver.Name = "bt_Volver";
            this.bt_Volver.Size = new System.Drawing.Size(75, 23);
            this.bt_Volver.TabIndex = 1;
            this.bt_Volver.Text = "Volver";
            this.bt_Volver.UseVisualStyleBackColor = true;
            this.bt_Volver.Click += new System.EventHandler(this.bt_Volver_Click);
            // 
            // bt_Borrar
            // 
            this.bt_Borrar.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Borrar.Location = new System.Drawing.Point(269, 165);
            this.bt_Borrar.Name = "bt_Borrar";
            this.bt_Borrar.Size = new System.Drawing.Size(75, 23);
            this.bt_Borrar.TabIndex = 2;
            this.bt_Borrar.Text = "Borrar";
            this.bt_Borrar.UseVisualStyleBackColor = true;
            this.bt_Borrar.Click += new System.EventHandler(this.bt_Borrar_Click);
            // 
            // fr_Intentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(356, 194);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Borrar);
            this.Controls.Add(this.bt_Volver);
            this.Controls.Add(this.list_Intentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fr_Intentos";
            this.Text = "Intentos de conexión fallidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_Intentos;
        private System.Windows.Forms.Button bt_Volver;
        private System.Windows.Forms.Button bt_Borrar;
    }
}