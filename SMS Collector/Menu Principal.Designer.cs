namespace SMS_Collector
{
    partial class fr_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarCopiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.restaurarCopiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rastreoDeIntentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_NuevoSMS = new System.Windows.Forms.Button();
            this.bt_VisualizarSMS = new System.Windows.Forms.Button();
            this.bt_Salir = new System.Windows.Forms.Button();
            this.gb_MenuOpciones = new System.Windows.Forms.GroupBox();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.gb_MenuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoSMSToolStripMenuItem,
            this.visualizarSMSToolStripMenuItem,
            this.toolStripSeparator1,
            this.preferenciasToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoSMSToolStripMenuItem
            // 
            this.nuevoSMSToolStripMenuItem.Name = "nuevoSMSToolStripMenuItem";
            this.nuevoSMSToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nuevoSMSToolStripMenuItem.Text = "Nuevo SMS";
            this.nuevoSMSToolStripMenuItem.Click += new System.EventHandler(this.bt_NuevoSMS_Click);
            // 
            // visualizarSMSToolStripMenuItem
            // 
            this.visualizarSMSToolStripMenuItem.Name = "visualizarSMSToolStripMenuItem";
            this.visualizarSMSToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.visualizarSMSToolStripMenuItem.Text = "Visualizar SMS";
            this.visualizarSMSToolStripMenuItem.Click += new System.EventHandler(this.bt_VisualizarSMS_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // preferenciasToolStripMenuItem
            // 
            this.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            this.preferenciasToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.preferenciasToolStripMenuItem.Text = "Preferencias";
            this.preferenciasToolStripMenuItem.Click += new System.EventHandler(this.preferenciasToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.bt_Salir_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiaDeSeguridadToolStripMenuItem,
            this.ordenarRegistroToolStripMenuItem,
            this.rastreoDeIntentosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // copiaDeSeguridadToolStripMenuItem
            // 
            this.copiaDeSeguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarCopiaToolStripMenuItem,
            this.toolStripSeparator3,
            this.restaurarCopiaToolStripMenuItem});
            this.copiaDeSeguridadToolStripMenuItem.Name = "copiaDeSeguridadToolStripMenuItem";
            this.copiaDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.copiaDeSeguridadToolStripMenuItem.Text = "Copia De Seguridad";
            // 
            // realizarCopiaToolStripMenuItem
            // 
            this.realizarCopiaToolStripMenuItem.Name = "realizarCopiaToolStripMenuItem";
            this.realizarCopiaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.realizarCopiaToolStripMenuItem.Text = "Realizar Copia";
            this.realizarCopiaToolStripMenuItem.Click += new System.EventHandler(this.realizarCopiaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(154, 6);
            // 
            // restaurarCopiaToolStripMenuItem
            // 
            this.restaurarCopiaToolStripMenuItem.Name = "restaurarCopiaToolStripMenuItem";
            this.restaurarCopiaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.restaurarCopiaToolStripMenuItem.Text = "Restaurar Copia";
            this.restaurarCopiaToolStripMenuItem.Click += new System.EventHandler(this.restaurarCopiaToolStripMenuItem_Click);
            // 
            // ordenarRegistroToolStripMenuItem
            // 
            this.ordenarRegistroToolStripMenuItem.Name = "ordenarRegistroToolStripMenuItem";
            this.ordenarRegistroToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ordenarRegistroToolStripMenuItem.Text = "Ordenar Registro";
            this.ordenarRegistroToolStripMenuItem.Click += new System.EventHandler(this.ordenarRegistroToolStripMenuItem_Click);
            // 
            // rastreoDeIntentosToolStripMenuItem
            // 
            this.rastreoDeIntentosToolStripMenuItem.Name = "rastreoDeIntentosToolStripMenuItem";
            this.rastreoDeIntentosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.rastreoDeIntentosToolStripMenuItem.Text = "Rastreo Intentos";
            this.rastreoDeIntentosToolStripMenuItem.Click += new System.EventHandler(this.rastreoIntentosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLogToolStripMenuItem,
            this.readMeToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // changeLogToolStripMenuItem
            // 
            this.changeLogToolStripMenuItem.Name = "changeLogToolStripMenuItem";
            this.changeLogToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.changeLogToolStripMenuItem.Text = "ChangeLog";
            this.changeLogToolStripMenuItem.Click += new System.EventHandler(this.changeLogToolStripMenuItem_Click);
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.readMeToolStripMenuItem.Text = "ReadMe";
            this.readMeToolStripMenuItem.Click += new System.EventHandler(this.readMeToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // bt_NuevoSMS
            // 
            this.bt_NuevoSMS.Location = new System.Drawing.Point(13, 24);
            this.bt_NuevoSMS.Name = "bt_NuevoSMS";
            this.bt_NuevoSMS.Size = new System.Drawing.Size(115, 23);
            this.bt_NuevoSMS.TabIndex = 0;
            this.bt_NuevoSMS.Text = "Nuevo SMS";
            this.bt_NuevoSMS.UseVisualStyleBackColor = true;
            this.bt_NuevoSMS.Click += new System.EventHandler(this.bt_NuevoSMS_Click);
            // 
            // bt_VisualizarSMS
            // 
            this.bt_VisualizarSMS.Location = new System.Drawing.Point(13, 53);
            this.bt_VisualizarSMS.Name = "bt_VisualizarSMS";
            this.bt_VisualizarSMS.Size = new System.Drawing.Size(115, 23);
            this.bt_VisualizarSMS.TabIndex = 1;
            this.bt_VisualizarSMS.Text = "Visualizar SMS";
            this.bt_VisualizarSMS.UseVisualStyleBackColor = true;
            this.bt_VisualizarSMS.Click += new System.EventHandler(this.bt_VisualizarSMS_Click);
            // 
            // bt_Salir
            // 
            this.bt_Salir.Location = new System.Drawing.Point(13, 82);
            this.bt_Salir.Name = "bt_Salir";
            this.bt_Salir.Size = new System.Drawing.Size(115, 23);
            this.bt_Salir.TabIndex = 2;
            this.bt_Salir.Text = "Salir";
            this.bt_Salir.UseVisualStyleBackColor = true;
            this.bt_Salir.Click += new System.EventHandler(this.bt_Salir_Click);
            // 
            // gb_MenuOpciones
            // 
            this.gb_MenuOpciones.Controls.Add(this.bt_NuevoSMS);
            this.gb_MenuOpciones.Controls.Add(this.bt_Salir);
            this.gb_MenuOpciones.Controls.Add(this.bt_VisualizarSMS);
            this.gb_MenuOpciones.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_MenuOpciones.Location = new System.Drawing.Point(73, 95);
            this.gb_MenuOpciones.Name = "gb_MenuOpciones";
            this.gb_MenuOpciones.Size = new System.Drawing.Size(140, 117);
            this.gb_MenuOpciones.TabIndex = 5;
            this.gb_MenuOpciones.TabStop = false;
            this.gb_MenuOpciones.Text = "Menu de Opciones";
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = global::SMS_Collector.Properties.Resources.Logo;
            this.pb_Logo.Location = new System.Drawing.Point(43, 44);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(200, 35);
            this.pb_Logo.TabIndex = 1;
            this.pb_Logo.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(61, 249);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 14);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "©2007 Sinister Software";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // fr_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gb_MenuOpciones);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fr_MenuPrincipal";
            this.Text = "SMS Collector";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_MenuOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button bt_NuevoSMS;
        private System.Windows.Forms.Button bt_VisualizarSMS;
        private System.Windows.Forms.Button bt_Salir;
        private System.Windows.Forms.GroupBox gb_MenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem nuevoSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem preferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarCopiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarCopiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem rastreoDeIntentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogToolStripMenuItem;
    }
}

