using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace SMS_Collector
{
    public partial class fr_AñadirContacto : Form
    {
        int movil;
        fr_Visualizar visualizar;

        public fr_AñadirContacto(string movil2, fr_Visualizar visualizar2)
        {
            movil = Convert.ToInt32(movil2);
            visualizar = visualizar2;
            InitializeComponent();
            lb_Movil.Text = "Nº de Móvil: " + Convert.ToString(movil);
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            visualizar.Show();
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            FileStream flujo = null;
            BinaryFormatter serie = new BinaryFormatter();

            if ((tb_Nombre.Text.Length > 0) && (tb_Apellidos.Text.Length > 0) && (tb_Email.Text.Length > 0))
            {
                Persona aux = new Persona(tb_Nombre.Text, tb_Apellidos.Text, tb_Email.Text, (Int32)movil);
                if (File.Exists("Numeros.dat"))
                {
                    flujo = new FileStream("Numeros.dat", FileMode.Append, FileAccess.Write);
                }
                else
                {
                    flujo = new FileStream("Numeros.dat", FileMode.Create, FileAccess.Write);
                }
                serie.Serialize(flujo, aux);
                flujo.Close();
                MessageBox.Show("Perfil guardado con éxito", "Información", MessageBoxButtons.OK);
                this.Close();
                visualizar.Show();
            }
            else
            {
                MessageBox.Show("Asegúrese de rellenar todos los campos", "Atención", MessageBoxButtons.OK);
            }
        }
    }
}