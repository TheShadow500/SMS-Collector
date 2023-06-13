namespace SMS_Collector
{
    partial class fr_Modificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Modificar));
            this.lb_Encontrados = new System.Windows.Forms.Label();
            this.lb_ListaMensajes = new System.Windows.Forms.Label();
            this.list_Resultado = new System.Windows.Forms.ListBox();
            this.bt_Volver = new System.Windows.Forms.Button();
            this.gb_DatosSMS = new System.Windows.Forms.GroupBox();
            this.lb_Caracteres = new System.Windows.Forms.Label();
            this.tb_Mensaje = new System.Windows.Forms.TextBox();
            this.lb_Mensaje = new System.Windows.Forms.Label();
            this.lb_DosPuntos = new System.Windows.Forms.Label();
            this.tb_Minuto = new System.Windows.Forms.TextBox();
            this.tb_Hora = new System.Windows.Forms.TextBox();
            this.lb_Hora = new System.Windows.Forms.Label();
            this.cb_Año = new System.Windows.Forms.ComboBox();
            this.cb_Mes = new System.Windows.Forms.ComboBox();
            this.cb_Dia = new System.Windows.Forms.ComboBox();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.lb_Numero = new System.Windows.Forms.Label();
            this.tb_Numero = new System.Windows.Forms.TextBox();
            this.gb_DatosSMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Encontrados
            // 
            this.lb_Encontrados.AutoSize = true;
            this.lb_Encontrados.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Encontrados.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_Encontrados.Location = new System.Drawing.Point(9, 189);
            this.lb_Encontrados.Name = "lb_Encontrados";
            this.lb_Encontrados.Size = new System.Drawing.Size(101, 17);
            this.lb_Encontrados.TabIndex = 11;
            this.lb_Encontrados.Text = "Encontrados: 0";
            // 
            // lb_ListaMensajes
            // 
            this.lb_ListaMensajes.AutoSize = true;
            this.lb_ListaMensajes.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ListaMensajes.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_ListaMensajes.Location = new System.Drawing.Point(9, 12);
            this.lb_ListaMensajes.Name = "lb_ListaMensajes";
            this.lb_ListaMensajes.Size = new System.Drawing.Size(94, 17);
            this.lb_ListaMensajes.TabIndex = 10;
            this.lb_ListaMensajes.Text = "Lista de SMS: ";
            // 
            // list_Resultado
            // 
            this.list_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_Resultado.FormattingEnabled = true;
            this.list_Resultado.Location = new System.Drawing.Point(12, 35);
            this.list_Resultado.Name = "list_Resultado";
            this.list_Resultado.Size = new System.Drawing.Size(213, 145);
            this.list_Resultado.TabIndex = 8;
            this.list_Resultado.SelectedIndexChanged += new System.EventHandler(this.list_Resultado_SelectedIndexChanged);
            // 
            // bt_Volver
            // 
            this.bt_Volver.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Volver.Location = new System.Drawing.Point(150, 190);
            this.bt_Volver.Name = "bt_Volver";
            this.bt_Volver.Size = new System.Drawing.Size(75, 23);
            this.bt_Volver.TabIndex = 9;
            this.bt_Volver.Text = "Volver";
            this.bt_Volver.UseVisualStyleBackColor = true;
            this.bt_Volver.Click += new System.EventHandler(this.bt_Volver_Click);
            // 
            // gb_DatosSMS
            // 
            this.gb_DatosSMS.Controls.Add(this.tb_Numero);
            this.gb_DatosSMS.Controls.Add(this.lb_Numero);
            this.gb_DatosSMS.Controls.Add(this.bt_Modificar);
            this.gb_DatosSMS.Controls.Add(this.lb_Caracteres);
            this.gb_DatosSMS.Controls.Add(this.tb_Mensaje);
            this.gb_DatosSMS.Controls.Add(this.lb_Mensaje);
            this.gb_DatosSMS.Controls.Add(this.lb_DosPuntos);
            this.gb_DatosSMS.Controls.Add(this.tb_Minuto);
            this.gb_DatosSMS.Controls.Add(this.tb_Hora);
            this.gb_DatosSMS.Controls.Add(this.lb_Hora);
            this.gb_DatosSMS.Controls.Add(this.cb_Año);
            this.gb_DatosSMS.Controls.Add(this.cb_Mes);
            this.gb_DatosSMS.Controls.Add(this.cb_Dia);
            this.gb_DatosSMS.Controls.Add(this.lb_Fecha);
            this.gb_DatosSMS.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DatosSMS.ForeColor = System.Drawing.SystemColors.Window;
            this.gb_DatosSMS.Location = new System.Drawing.Point(231, 12);
            this.gb_DatosSMS.Name = "gb_DatosSMS";
            this.gb_DatosSMS.Size = new System.Drawing.Size(235, 201);
            this.gb_DatosSMS.TabIndex = 12;
            this.gb_DatosSMS.TabStop = false;
            this.gb_DatosSMS.Text = "Datos del SMS";
            // 
            // lb_Caracteres
            // 
            this.lb_Caracteres.AutoSize = true;
            this.lb_Caracteres.Location = new System.Drawing.Point(79, 169);
            this.lb_Caracteres.Name = "lb_Caracteres";
            this.lb_Caracteres.Size = new System.Drawing.Size(51, 17);
            this.lb_Caracteres.TabIndex = 13;
            this.lb_Caracteres.Text = "0/1000";
            // 
            // tb_Mensaje
            // 
            this.tb_Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mensaje.Location = new System.Drawing.Point(12, 115);
            this.tb_Mensaje.MaxLength = 1000;
            this.tb_Mensaje.Multiline = true;
            this.tb_Mensaje.Name = "tb_Mensaje";
            this.tb_Mensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Mensaje.Size = new System.Drawing.Size(209, 51);
            this.tb_Mensaje.TabIndex = 6;
            this.tb_Mensaje.TextChanged += new System.EventHandler(this.tb_Mensaje_TextChanged);
            // 
            // lb_Mensaje
            // 
            this.lb_Mensaje.AutoSize = true;
            this.lb_Mensaje.Location = new System.Drawing.Point(9, 169);
            this.lb_Mensaje.Name = "lb_Mensaje";
            this.lb_Mensaje.Size = new System.Drawing.Size(64, 17);
            this.lb_Mensaje.TabIndex = 10;
            this.lb_Mensaje.Text = "Mensaje:";
            // 
            // lb_DosPuntos
            // 
            this.lb_DosPuntos.AutoSize = true;
            this.lb_DosPuntos.Location = new System.Drawing.Point(86, 87);
            this.lb_DosPuntos.Name = "lb_DosPuntos";
            this.lb_DosPuntos.Size = new System.Drawing.Size(12, 17);
            this.lb_DosPuntos.TabIndex = 9;
            this.lb_DosPuntos.Text = ":";
            // 
            // tb_Minuto
            // 
            this.tb_Minuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Minuto.Location = new System.Drawing.Point(99, 84);
            this.tb_Minuto.MaxLength = 2;
            this.tb_Minuto.Name = "tb_Minuto";
            this.tb_Minuto.Size = new System.Drawing.Size(21, 20);
            this.tb_Minuto.TabIndex = 5;
            this.tb_Minuto.Text = "00";
            // 
            // tb_Hora
            // 
            this.tb_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Hora.Location = new System.Drawing.Point(63, 84);
            this.tb_Hora.MaxLength = 2;
            this.tb_Hora.Name = "tb_Hora";
            this.tb_Hora.Size = new System.Drawing.Size(21, 20);
            this.tb_Hora.TabIndex = 4;
            this.tb_Hora.Text = "00";
            // 
            // lb_Hora
            // 
            this.lb_Hora.AutoSize = true;
            this.lb_Hora.Location = new System.Drawing.Point(9, 87);
            this.lb_Hora.Name = "lb_Hora";
            this.lb_Hora.Size = new System.Drawing.Size(45, 17);
            this.lb_Hora.TabIndex = 6;
            this.lb_Hora.Text = "Hora:";
            // 
            // cb_Año
            // 
            this.cb_Año.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Año.FormattingEnabled = true;
            this.cb_Año.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.cb_Año.Location = new System.Drawing.Point(166, 57);
            this.cb_Año.Name = "cb_Año";
            this.cb_Año.Size = new System.Drawing.Size(55, 21);
            this.cb_Año.TabIndex = 3;
            this.cb_Año.Text = "1990";
            // 
            // cb_Mes
            // 
            this.cb_Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Mes.FormattingEnabled = true;
            this.cb_Mes.Items.AddRange(new object[] {
            "Ene",
            "Feb",
            "Mar",
            "Abr",
            "May",
            "Jun",
            "Jul",
            "Ago",
            "Sep",
            "Oct",
            "Nov",
            "Dic"});
            this.cb_Mes.Location = new System.Drawing.Point(110, 57);
            this.cb_Mes.Name = "cb_Mes";
            this.cb_Mes.Size = new System.Drawing.Size(50, 21);
            this.cb_Mes.TabIndex = 2;
            this.cb_Mes.Text = "Ene";
            // 
            // cb_Dia
            // 
            this.cb_Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Dia.FormattingEnabled = true;
            this.cb_Dia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cb_Dia.Location = new System.Drawing.Point(63, 57);
            this.cb_Dia.Name = "cb_Dia";
            this.cb_Dia.Size = new System.Drawing.Size(41, 21);
            this.cb_Dia.TabIndex = 1;
            this.cb_Dia.Text = "1";
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Location = new System.Drawing.Point(9, 60);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(48, 17);
            this.lb_Fecha.TabIndex = 0;
            this.lb_Fecha.Text = "Fecha:";
            // 
            // bt_Modificar
            // 
            this.bt_Modificar.Enabled = false;
            this.bt_Modificar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bt_Modificar.Location = new System.Drawing.Point(147, 171);
            this.bt_Modificar.Name = "bt_Modificar";
            this.bt_Modificar.Size = new System.Drawing.Size(82, 23);
            this.bt_Modificar.TabIndex = 14;
            this.bt_Modificar.Text = "Modificar";
            this.bt_Modificar.UseVisualStyleBackColor = true;
            this.bt_Modificar.Click += new System.EventHandler(this.bt_Modificar_Click);
            // 
            // lb_Numero
            // 
            this.lb_Numero.AutoSize = true;
            this.lb_Numero.Location = new System.Drawing.Point(40, 29);
            this.lb_Numero.Name = "lb_Numero";
            this.lb_Numero.Size = new System.Drawing.Size(69, 17);
            this.lb_Numero.TabIndex = 15;
            this.lb_Numero.Text = "Nº Móvil:";
            // 
            // tb_Numero
            // 
            this.tb_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tb_Numero.Location = new System.Drawing.Point(110, 27);
            this.tb_Numero.Name = "tb_Numero";
            this.tb_Numero.Size = new System.Drawing.Size(80, 20);
            this.tb_Numero.TabIndex = 16;
            // 
            // fr_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(474, 225);
            this.ControlBox = false;
            this.Controls.Add(this.gb_DatosSMS);
            this.Controls.Add(this.lb_Encontrados);
            this.Controls.Add(this.lb_ListaMensajes);
            this.Controls.Add(this.list_Resultado);
            this.Controls.Add(this.bt_Volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fr_Modificar";
            this.Text = "Modificar";
            this.gb_DatosSMS.ResumeLayout(false);
            this.gb_DatosSMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Encontrados;
        private System.Windows.Forms.Label lb_ListaMensajes;
        private System.Windows.Forms.ListBox list_Resultado;
        private System.Windows.Forms.Button bt_Volver;
        private System.Windows.Forms.GroupBox gb_DatosSMS;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.Label lb_Caracteres;
        private System.Windows.Forms.TextBox tb_Mensaje;
        private System.Windows.Forms.Label lb_Mensaje;
        private System.Windows.Forms.Label lb_DosPuntos;
        private System.Windows.Forms.TextBox tb_Minuto;
        private System.Windows.Forms.TextBox tb_Hora;
        private System.Windows.Forms.Label lb_Hora;
        private System.Windows.Forms.ComboBox cb_Año;
        private System.Windows.Forms.ComboBox cb_Mes;
        private System.Windows.Forms.ComboBox cb_Dia;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.TextBox tb_Numero;
        private System.Windows.Forms.Label lb_Numero;
    }
}