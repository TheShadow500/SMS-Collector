using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SMS_Collector
{
    public partial class fr_Verificacion1 : Form
    {
        string usuario;
        int contraseña;
        int opcion;
        fr_MenuPrincipal menu;

        public fr_Verificacion1(string usuario2, int contraseña2, int opcion2, fr_MenuPrincipal menu2)
        {
            usuario = usuario2;
            contraseña = contraseña2;
            opcion = opcion2;
            menu = menu2;
            InitializeComponent();
            lb_Usuario2.Text = usuario;
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            int aux = 0;
            int sw;

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
                    if (opcion == 1)
                    {
                        tb_Contraseña.Clear();
                        fr_NuevoSMS NuevoSMS = new fr_NuevoSMS(usuario, contraseña, menu, this);
                        NuevoSMS.StartPosition = FormStartPosition.CenterScreen;
                        NuevoSMS.Show();
                    }
                    else if (opcion == 2)
                    {
                        tb_Contraseña.Clear();
                        fr_Visualizar visualizar = new fr_Visualizar(usuario, contraseña, menu, this);
                        visualizar.StartPosition = FormStartPosition.CenterScreen;
                        visualizar.Show();
                    }
                }
                else
                {
                    BinaryFormatter serie = new BinaryFormatter();
                    FileStream flujo;
                    string error;

                    MessageBox.Show("La Contraseña introducida es incorrecta.\nSe ha abierto un parte de rastreo para informar al\nusuario del intento de conexión", "Error", MessageBoxButtons.OK);
                    error = Convert.ToString("Usuario: "+usuario+" - "+DateTime.Now +" - Contraseña: " + tb_Contraseña.Text);
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