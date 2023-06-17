using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SMS_Collector
{
    public partial class fr_Intentos : Form
    {
        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;
        string dato = null;
        string usuario;
        int contraseña;

        public fr_Intentos(Configuracion usuario2)
        {
            usuario = usuario2.DevolverUsuario;
            contraseña = usuario2.DevolverContrasena;
            InitializeComponent();
            if (File.Exists("Intentos.dat"))
            {
                flujo = new FileStream("Intentos.dat", FileMode.Open, FileAccess.Read);
                try
                {
                    while (true)
                    {
                        dato = (String)serie.Deserialize(flujo);
                        list_Intentos.Items.Add(dato);
                    }
                }
                catch (SerializationException) { }
                catch (EndOfStreamException) { }
                finally
                {
                    flujo.Close();
                }
            }
            else
            {
                list_Intentos.Items.Add("No hay ningun registro");
            }
        }

        private void bt_Borrar_Click(object sender, EventArgs e)
        {
            fr_Verificacion3 verificacion3 = new fr_Verificacion3(usuario, contraseña);
            verificacion3.ShowDialog();
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}