namespace SMS_Collector
{
    partial class fr_NuevoSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_NuevoSMS));
            this.bt_Volver = new System.Windows.Forms.Button();
            this.bt_Guardar = new System.Windows.Forms.Button();
            this.tb_Numero = new System.Windows.Forms.TextBox();
            this.lb_Numero = new System.Windows.Forms.Label();
            this.gb_DatosSMS = new System.Windows.Forms.GroupBox();
            this.cb_Minuto = new System.Windows.Forms.ComboBox();
            this.cb_Hora = new System.Windows.Forms.ComboBox();
            this.lb_Caracteres = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_Mensaje = new System.Windows.Forms.TextBox();
            this.lb_Mensaje = new System.Windows.Forms.Label();
            this.lb_DosPuntos = new System.Windows.Forms.Label();
            this.lb_Hora = new System.Windows.Forms.Label();
            this.cb_Año = new System.Windows.Forms.ComboBox();
            this.cb_Mes = new System.Windows.Forms.ComboBox();
            this.cb_Dia = new System.Windows.Forms.ComboBox();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.lb_Usuario = new System.Windows.Forms.Label();
            this.gb_DatosSMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Volver
            // 
            this.bt_Volver.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Volver.Location = new System.Drawing.Point(15, 231);
            this.bt_Volver.Name = "bt_Volver";
            this.bt_Volver.Size = new System.Drawing.Size(75, 23);
            this.bt_Volver.TabIndex = 8;
            this.bt_Volver.Text = "Volver";
            this.bt_Volver.UseVisualStyleBackColor = true;
            this.bt_Volver.Click += new System.EventHandler(this.bt_Volver_Click);
            // 
            // bt_Guardar
            // 
            this.bt_Guardar.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Guardar.Location = new System.Drawing.Point(175, 231);
            this.bt_Guardar.Name = "bt_Guardar";
            this.bt_Guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_Guardar.TabIndex = 7;
            this.bt_Guardar.Text = "Guardar";
            this.bt_Guardar.UseVisualStyleBackColor = true;
            this.bt_Guardar.Click += new System.EventHandler(this.bt_Guardar_Click);
            // 
            // tb_Numero
            // 
            this.tb_Numero.Location = new System.Drawing.Point(140, 29);
            this.tb_Numero.MaxLength = 9;
            this.tb_Numero.Name = "tb_Numero";
            this.tb_Numero.Size = new System.Drawing.Size(83, 20);
            this.tb_Numero.TabIndex = 0;
            // 
            // lb_Numero
            // 
            this.lb_Numero.AutoSize = true;
            this.lb_Numero.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Numero.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_Numero.Location = new System.Drawing.Point(36, 31);
            this.lb_Numero.Name = "lb_Numero";
            this.lb_Numero.Size = new System.Drawing.Size(88, 17);
            this.lb_Numero.TabIndex = 3;
            this.lb_Numero.Text = "Nº de Móvil:";
            // 
            // gb_DatosSMS
            // 
            this.gb_DatosSMS.Controls.Add(this.cb_Minuto);
            this.gb_DatosSMS.Controls.Add(this.cb_Hora);
            this.gb_DatosSMS.Controls.Add(this.lb_Caracteres);
            this.gb_DatosSMS.Controls.Add(this.pictureBox1);
            this.gb_DatosSMS.Controls.Add(this.tb_Mensaje);
            this.gb_DatosSMS.Controls.Add(this.lb_Mensaje);
            this.gb_DatosSMS.Controls.Add(this.lb_DosPuntos);
            this.gb_DatosSMS.Controls.Add(this.lb_Hora);
            this.gb_DatosSMS.Controls.Add(this.cb_Año);
            this.gb_DatosSMS.Controls.Add(this.cb_Mes);
            this.gb_DatosSMS.Controls.Add(this.cb_Dia);
            this.gb_DatosSMS.Controls.Add(this.lb_Fecha);
            this.gb_DatosSMS.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DatosSMS.ForeColor = System.Drawing.SystemColors.Window;
            this.gb_DatosSMS.Location = new System.Drawing.Point(15, 55);
            this.gb_DatosSMS.Name = "gb_DatosSMS";
            this.gb_DatosSMS.Size = new System.Drawing.Size(235, 170);
            this.gb_DatosSMS.TabIndex = 4;
            this.gb_DatosSMS.TabStop = false;
            this.gb_DatosSMS.Text = "Datos del SMS";
            // 
            // cb_Minuto
            // 
            this.cb_Minuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Minuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cb_Minuto.FormattingEnabled = true;
            this.cb_Minuto.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cb_Minuto.Location = new System.Drawing.Point(119, 53);
            this.cb_Minuto.Name = "cb_Minuto";
            this.cb_Minuto.Size = new System.Drawing.Size(41, 21);
            this.cb_Minuto.TabIndex = 15;
            // 
            // cb_Hora
            // 
            this.cb_Hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cb_Hora.FormattingEnabled = true;
            this.cb_Hora.Items.AddRange(new object[] {
            "0",
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
            "23"});
            this.cb_Hora.Location = new System.Drawing.Point(63, 53);
            this.cb_Hora.Name = "cb_Hora";
            this.cb_Hora.Size = new System.Drawing.Size(41, 21);
            this.cb_Hora.TabIndex = 14;
            // 
            // lb_Caracteres
            // 
            this.lb_Caracteres.AutoSize = true;
            this.lb_Caracteres.Location = new System.Drawing.Point(84, 86);
            this.lb_Caracteres.Name = "lb_Caracteres";
            this.lb_Caracteres.Size = new System.Drawing.Size(51, 17);
            this.lb_Caracteres.TabIndex = 13;
            this.lb_Caracteres.Text = "0/1000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tb_Mensaje
            // 
            this.tb_Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mensaje.Location = new System.Drawing.Point(12, 106);
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
            this.lb_Mensaje.Location = new System.Drawing.Point(9, 86);
            this.lb_Mensaje.Name = "lb_Mensaje";
            this.lb_Mensaje.Size = new System.Drawing.Size(64, 17);
            this.lb_Mensaje.TabIndex = 10;
            this.lb_Mensaje.Text = "Mensaje:";
            // 
            // lb_DosPuntos
            // 
            this.lb_DosPuntos.AutoSize = true;
            this.lb_DosPuntos.Location = new System.Drawing.Point(107, 58);
            this.lb_DosPuntos.Name = "lb_DosPuntos";
            this.lb_DosPuntos.Size = new System.Drawing.Size(12, 17);
            this.lb_DosPuntos.TabIndex = 9;
            this.lb_DosPuntos.Text = ":";
            // 
            // lb_Hora
            // 
            this.lb_Hora.AutoSize = true;
            this.lb_Hora.Location = new System.Drawing.Point(9, 57);
            this.lb_Hora.Name = "lb_Hora";
            this.lb_Hora.Size = new System.Drawing.Size(45, 17);
            this.lb_Hora.TabIndex = 6;
            this.lb_Hora.Text = "Hora:";
            // 
            // cb_Año
            // 
            this.cb_Año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cb_Año.Location = new System.Drawing.Point(166, 23);
            this.cb_Año.Name = "cb_Año";
            this.cb_Año.Size = new System.Drawing.Size(55, 21);
            this.cb_Año.TabIndex = 3;
            this.cb_Año.SelectedIndexChanged += new System.EventHandler(this.cb_Año_SelectedIndexChanged);
            // 
            // cb_Mes
            // 
            this.cb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cb_Mes.Location = new System.Drawing.Point(110, 23);
            this.cb_Mes.Name = "cb_Mes";
            this.cb_Mes.Size = new System.Drawing.Size(50, 21);
            this.cb_Mes.TabIndex = 2;
            this.cb_Mes.SelectedIndexChanged += new System.EventHandler(this.cb_Mes_SelectedIndexChanged);
            // 
            // cb_Dia
            // 
            this.cb_Dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cb_Dia.Location = new System.Drawing.Point(63, 23);
            this.cb_Dia.Name = "cb_Dia";
            this.cb_Dia.Size = new System.Drawing.Size(41, 21);
            this.cb_Dia.TabIndex = 1;
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Location = new System.Drawing.Point(9, 26);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(48, 17);
            this.lb_Fecha.TabIndex = 0;
            this.lb_Fecha.Text = "Fecha:";
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.AutoSize = true;
            this.lb_Usuario.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_Usuario.Location = new System.Drawing.Point(36, 9);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(61, 17);
            this.lb_Usuario.TabIndex = 5;
            this.lb_Usuario.Text = "Usuario:";
            // 
            // fr_NuevoSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(264, 266);
            this.ControlBox = false;
            this.Controls.Add(this.lb_Usuario);
            this.Controls.Add(this.gb_DatosSMS);
            this.Controls.Add(this.lb_Numero);
            this.Controls.Add(this.tb_Numero);
            this.Controls.Add(this.bt_Guardar);
            this.Controls.Add(this.bt_Volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fr_NuevoSMS";
            this.Text = "Añadir Nuevo SMS - SMS Collector";
            this.gb_DatosSMS.ResumeLayout(false);
            this.gb_DatosSMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Volver;
        private System.Windows.Forms.Button bt_Guardar;
        private System.Windows.Forms.TextBox tb_Numero;
        private System.Windows.Forms.Label lb_Numero;
        private System.Windows.Forms.GroupBox gb_DatosSMS;
        private System.Windows.Forms.Label lb_Usuario;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.ComboBox cb_Año;
        private System.Windows.Forms.ComboBox cb_Mes;
        private System.Windows.Forms.ComboBox cb_Dia;
        private System.Windows.Forms.Label lb_DosPuntos;
        private System.Windows.Forms.Label lb_Hora;
        private System.Windows.Forms.Label lb_Mensaje;
        private System.Windows.Forms.TextBox tb_Mensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Caracteres;
        private System.Windows.Forms.ComboBox cb_Minuto;
        private System.Windows.Forms.ComboBox cb_Hora;
    }
}