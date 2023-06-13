using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SMS_Collector
{
    public partial class fr_Verificacion3 : Form
    {
        string usuario;
        int contraseña;

        public fr_Verificacion3(string usuario2, int contraseña2)
        {
            usuario = usuario2;
            contraseña = contraseña2;
            InitializeComponent();
            lb_Usuario2.Text = usuario;
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            int aux = 0;
            int sw = 0;

            try
            {
                sw = 1;
                aux = Int32.Parse(tb_Contraseña.Text);
            }
            catch (FormatException)
            {
                sw = 0;
                MessageBox.Show("Asegúrese de que la contraseña este compuesta tan sólo por números comprendidos del 0 al 9", "Error", MessageBoxButtons.OK);
            }
            catch (OverflowException)
            {
                sw = 0;
                MessageBox.Show("La contraseña introducida es demasiado larga");
            }
            if (sw == 1)
            {
                if (aux == contraseña)
                {
                    tb_Contraseña.Clear();
                    if (File.Exists("Intentos.dat"))
                    {
                        File.Delete("Intentos.dat");
                        MessageBox.Show("Archivo de registro eliminado", "Información", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                {
                    BinaryFormatter serie = new BinaryFormatter();
                    FileStream flujo;
                    string error;

                    MessageBox.Show("La Contraseña introducida es incorrecta.\nSe ha abierto un parte de rastreo para informar al\nusuario del intento de conexión", "Error", MessageBoxButtons.OK);
                    error = Convert.ToString("Usuario: " + usuario + " - " + DateTime.Now + " - Contraseña: " + tb_Contraseña.Text);
                    if (File.Exists("Intentos.dat"))
                    {
                        flujo = new FileStream("Intentos.dat", FileMode.Append, FileAccess.Write);
                        serie.Serialize(flujo, error);
                    }
                    else
                    {
                        flujo = new FileStream("Intentos.dat", FileMode.Create, FileAccess.Write);
                        serie.Serialize(flujo, error);
                    }
                    flujo.Close();
                    tb_Contraseña.Clear();
                }
            }
        }

        private void tb_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                bt_Aceptar_Click(null, null);
            }
        }
    }
}