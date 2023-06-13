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
        int contrase�a;

        public fr_Verificacion3(string usuario2, int contrase�a2)
        {
            usuario = usuario2;
            contrase�a = contrase�a2;
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
                aux = Int32.Parse(tb_Contrase�a.Text);
            }
            catch (FormatException)
            {
                sw = 0;
                MessageBox.Show("Aseg�rese de que la contrase�a este compuesta tan s�lo por n�meros comprendidos del 0 al 9", "Error", MessageBoxButtons.OK);
            }
            catch (OverflowException)
            {
                sw = 0;
                MessageBox.Show("La contrase�a introducida es demasiado larga");
            }
            if (sw == 1)
            {
                if (aux == contrase�a)
                {
                    tb_Contrase�a.Clear();
                    if (File.Exists("Intentos.dat"))
                    {
                        File.Delete("Intentos.dat");
                        MessageBox.Show("Archivo de registro eliminado", "Informaci�n", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                {
                    BinaryFormatter serie = new BinaryFormatter();
                    FileStream flujo;
                    string error;

                    MessageBox.Show("La Contrase�a introducida es incorrecta.\nSe ha abierto un parte de rastreo para informar al\nusuario del intento de conexi�n", "Error", MessageBoxButtons.OK);
                    error = Convert.ToString("Usuario: " + usuario + " - " + DateTime.Now + " - Contrase�a: " + tb_Contrase�a.Text);
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
                    tb_Contrase�a.Clear();
                }
            }
        }

        private void tb_Contrase�a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                bt_Aceptar_Click(null, null);
            }
        }
    }
}