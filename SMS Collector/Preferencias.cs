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
        int contraseña;
        int aux=0;

        public fr_Preferencias(string usuario2, int contraseña2)
        {
            usuario = usuario2;
            contraseña = contraseña2;
            InitializeComponent();
            tb_Usuario.Text = usuario;
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (tb_Contraseña.Text.Length >= 5)
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
                    MessageBox.Show("Asegúrese de que la contraseña esté compuesta sólo por números comprendidos del 0 al 9", "Error", MessageBoxButtons.OK);
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
                        try
                        {
                            sw = 1;
                            aux = Int32.Parse(tb_Contraseña.Text);
                        }
                        catch (FormatException)
                        {
                            sw = 0;
                            MessageBox.Show("Asegúrese de que la contraseña esté compuesta sólo por números comprendidos del 0 al 9", "Error", MessageBoxButtons.OK);
                        }
                        catch (OverflowException)
                        {
                            sw = 0;
                            MessageBox.Show("La contraseña introducida es demasiado larga");
                        }
                        if (sw == 1)
                        {
                            datos = new Configuracion(tb_Usuario.Text, aux);
                            flujo = new FileStream("Config.cfg", FileMode.Create, FileAccess.Write);
                            serie.Serialize(flujo, datos);
                            flujo.Close();
                            MessageBox.Show("Debe reiniciar el programa para que los cambios tengan efecto", "Información", MessageBoxButtons.OK);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La contraseña introducida no es válida", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de que la contraseña este compuesta por un mínimo de 5 dígitos", "Error", MessageBoxButtons.OK);
            }
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}