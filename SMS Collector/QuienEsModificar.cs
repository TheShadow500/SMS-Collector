using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SMS_Collector
{
    public partial class fr_QuienEsModificar : Form
    {
        Persona aux;
        fr_QuienEs quienes;

        public fr_QuienEsModificar(string nombre, string apellidos, string email, int movil, fr_QuienEs quienes2)
        {
            quienes = quienes2;
            aux = new Persona(nombre, apellidos, email, movil);
            InitializeComponent();
            tb_Nombre.Text = nombre;
            tb_Apellidos.Text = apellidos;
            tb_Email.Text = email;
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            quienes.Show();
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            if (File.Exists("Numeros.dat"))
            {
                int movil = aux.DevolverMovil;
                aux = new Persona(tb_Nombre.Text, tb_Apellidos.Text, tb_Email.Text, movil);
                BinaryFormatter serie=new BinaryFormatter();

                FileStream flujo = new FileStream("Numeros.dat", FileMode.Open, FileAccess.Read);
                FileStream flujo2 = new FileStream("Numeros2.dat", FileMode.Create, FileAccess.Write);
                try
                {
                    while (true)
                    {
                        Persona aux2 = (Persona)serie.Deserialize(flujo);
                        if (aux2.DevolverMovil == aux.DevolverMovil)
                        {
                            serie.Serialize(flujo2, aux);
                        }
                        else
                        {
                            serie.Serialize(flujo2, aux2);
                        }
                    }
                }
                catch (SerializationException) { }
                catch (EndOfStreamException) { }
                finally
                {
                    flujo.Close();
                    flujo2.Close();
                    File.Replace("Numeros2.dat", "Numeros.dat", "NumBack.dat");
                    File.Delete("NumBack.dat");
                    MessageBox.Show("Información de contacto modificada con éxito", "Atención", MessageBoxButtons.OK);
                }
            }
        }
    }
}