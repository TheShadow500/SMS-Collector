using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SMS_Collector
{
    public partial class fr_Preferencias : Form
    {
        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;
        Configuracion datos;
        string usuario;
        int contrase�a;
        int aux=0;

        public fr_Preferencias(string usuario2, int contrase�a2)
        {
            usuario = usuario2;
            contrase�a = contrase�a2;
            InitializeComponent();
            tb_Usuario.Text = usuario;
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (tb_Contrase�a.Text.Length >= 5)
            {
                int sw;
                try
                {
                    sw = 1;
                    aux = Int32.Parse(tb_Anterior.Text);
                }
                catch (FormatException)
                {
                    sw = 0;
                    MessageBox.Show("Aseg�rese de que la contrase�a est� compuesta s�lo por n�meros comprendidos del 0 al 9", "Error", MessageBoxButtons.OK);
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
                        try
                        {
                            sw = 1;
                            aux = Int32.Parse(tb_Contrase�a.Text);
                        }
                        catch (FormatException)
                        {
                            sw = 0;
                            MessageBox.Show("Aseg�rese de que la contrase�a est� compuesta s�lo por n�meros comprendidos del 0 al 9", "Error", MessageBoxButtons.OK);
                        }
                        catch (OverflowException)
                        {
                            sw = 0;
                            MessageBox.Show("La contrase�a introducida es demasiado larga");
                        }
                        if (sw == 1)
                        {
                            datos = new Configuracion(tb_Usuario.Text, aux);
                            flujo = new FileStream("Config.cfg", FileMode.Create, FileAccess.Write);
                            serie.Serialize(flujo, datos);
                            flujo.Close();
                            MessageBox.Show("Debe reiniciar el programa para que los cambios tengan efecto", "Informaci�n", MessageBoxButtons.OK);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La contrase�a introducida no es v�lida", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aseg�rese de que la contrase�a este compuesta por un m�nimo de 5 d�gitos", "Error", MessageBoxButtons.OK);
            }
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}