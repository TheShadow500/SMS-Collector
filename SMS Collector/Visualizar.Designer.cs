namespace SMS_Collector
{
    partial class fr_Visualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Visualizar));
            this.bt_Volver = new System.Windows.Forms.Button();
            this.lb_Numero = new System.Windows.Forms.Label();
            this.list_Resultado = new System.Windows.Forms.ListBox();
            this.lb_ListaMensajes = new System.Windows.Forms.Label();
            this.lb_Encontrados = new System.Windows.Forms.Label();
            this.cb_Numero = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modificarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_QuienEs = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Volver
            // 
            this.bt_Volver.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Volver.Location = new System.Drawing.Point(150, 214);
            this.bt_Volver.Name = "bt_Volver";
            this.bt_Volver.Size = new System.Drawing.Size(75, 23);
            this.bt_Volver.TabIndex = 3;
            this.bt_Volver.Text = "Volver";
            this.bt_Volver.UseVisualStyleBackColor = true;
            this.bt_Volver.Click += new System.EventHandler(this.bt_Volver_Click);
            // 
            // lb_Numero
            // 
            this.lb_Numero.AutoSize = true;
            this.lb_Numero.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Numero.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_Numero.Location = new System.Drawing.Point(13, 41);
            this.lb_Numero.Name = "lb_Numero";
            this.lb_Numero.Size = new System.Drawing.Size(88, 17);
            this.lb_Numero.TabIndex = 1;
            this.lb_Numero.Text = "Nº de Móvil:";
            // 
            // list_Resultado
            // 
            this.list_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_Resultado.FormattingEnabled = true;
            this.list_Resultado.Location = new System.Drawing.Point(12, 102);
            this.list_Resultado.Name = "list_Resultado";
            this.list_Resultado.Size = new System.Drawing.Size(213, 106);
            this.list_Resultado.TabIndex = 2;
            this.list_Resultado.SelectedIndexChanged += new System.EventHandler(this.list_Resultado_SelectedIndexChanged);
            // 
            // lb_ListaMensajes
            // 
            this.lb_ListaMensajes.AutoSize = true;
            this.lb_ListaMensajes.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ListaMensajes.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_ListaMensajes.Location = new System.Drawing.Point(30, 82);
            this.lb_ListaMensajes.Name = "lb_ListaMensajes";
            this.lb_ListaMensajes.Size = new System.Drawing.Size(181, 17);
            this.lb_ListaMensajes.TabIndex = 4;
            this.lb_ListaMensajes.Text = "Resultados para el número: ";
            // 
            // lb_Encontrados
            // 
            this.lb_Encontrados.AutoSize = true;
            this.lb_Encontrados.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Encontrados.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_Encontrados.Location = new System.Drawing.Point(9, 213);
            this.lb_Encontrados.Name = "lb_Encontrados";
            this.lb_Encontrados.Size = new System.Drawing.Size(101, 17);
            this.lb_Encontrados.TabIndex = 5;
            this.lb_Encontrados.Text = "Encontrados: 0";
            // 
            // cb_Numero
            // 
            this.cb_Numero.FormattingEnabled = true;
            this.cb_Numero.Location = new System.Drawing.Point(107, 39);
            this.cb_Numero.Name = "cb_Numero";
            this.cb_Numero.Size = new System.Drawing.Size(100, 21);
            this.cb_Numero.TabIndex = 1;
            this.cb_Numero.SelectedIndexChanged += new System.EventHandler(this.cb_Numero_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarRegistroToolStripMenuItem,
            this.eliminarRegistroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(237, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modificarRegistroToolStripMenuItem
            // 
            this.modificarRegistroToolStripMenuItem.Name = "modificarRegistroToolStripMenuItem";
            this.modificarRegistroToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.modificarRegistroToolStripMenuItem.Text = "Modificar Registro";
            this.modificarRegistroToolStripMenuItem.Click += new System.EventHandler(this.modificarRegistroToolStripMenuItem_Click);
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.eliminarRegistroToolStripMenuItem.Text = "Eliminar Registro";
            this.eliminarRegistroToolStripMenuItem.Click += new System.EventHandler(this.eliminarRegistroToolStripMenuItem_Click);
            // 
            // lb_QuienEs
            // 
            this.lb_QuienEs.AutoSize = true;
            this.lb_QuienEs.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuienEs.ForeColor = System.Drawing.Color.Orange;
            this.lb_QuienEs.Location = new System.Drawing.Point(210, 41);
            this.lb_QuienEs.Name = "lb_QuienEs";
            this.lb_QuienEs.Size = new System.Drawing.Size(16, 17);
            this.lb_QuienEs.TabIndex = 9;
            this.lb_QuienEs.Text = "?";
            this.lb_QuienEs.MouseLeave += new System.EventHandler(this.lb_QuienEs_MouseLeave);
            this.lb_QuienEs.Click += new System.EventHandler(this.lb_QuienEs_Click);
            this.lb_QuienEs.MouseEnter += new System.EventHandler(this.lb_QuienEs_MouseEnter);
            // 
            // fr_Visualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(237, 249);
            this.ControlBox = false;
            this.Controls.Add(this.lb_QuienEs);
            this.Controls.Add(this.cb_Numero);
            this.Controls.Add(this.lb_Encontrados);
            this.Controls.Add(this.lb_ListaMensajes);
            this.Controls.Add(this.list_Resultado);
            this.Controls.Add(this.lb_Numero);
            this.Controls.Add(this.bt_Volver);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fr_Visualizar";
            this.Text = "Visualizar SMS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Volver;
        private System.Windows.Forms.Label lb_Numero;
        private System.Windows.Forms.ListBox list_Resultado;
        private System.Windows.Forms.Label lb_ListaMensajes;
        private System.Windows.Forms.Label lb_Encontrados;
        private System.Windows.Forms.ComboBox cb_Numero;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
        private System.Windows.Forms.Label lb_QuienEs;
    }
}