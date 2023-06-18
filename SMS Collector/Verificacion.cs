using System;
using System.Windows.Forms;
using System.IO;

namespace SMS_Collector
{
    public partial class fr_Verificacion : Form
    {
        MetodosArchivos metodosArchivos = new MetodosArchivos();
        Configuracion usuario;
        int opcion;
        fr_MenuPrincipal menu;

        public fr_Verificacion(Configuracion usuario2, int opcion2, fr_MenuPrincipal menu2)
        {
            usuario = usuario2;
            opcion = opcion2;
            menu = menu2;

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            lb_Usuario2.Text = usuario2.DevolverUsuario;
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Int32.Parse(tb_Contrasena.Text) == usuario.DevolverContrasena)
                {
                    if (opcion == 1)
                    {
                        tb_Contrasena.Clear();
                        fr_NuevoSMS NuevoSMS = new fr_NuevoSMS(usuario, menu);
                        NuevoSMS.StartPosition = FormStartPosition.CenterScreen;
                        NuevoSMS.Show();
                    }
                    else if (opcion == 2)
                    {
                        tb_Contrasena.Clear();
                        fr_Visualizar visualizar = new fr_Visualizar(usuario, menu, this);
                        visualizar.StartPosition = FormStartPosition.CenterScreen;
                        visualizar.Show();
                    }
                    else if (opcion == 3)
                    {
                        tb_Contrasena.Clear();

                        if (File.Exists("Intentos.dat"))
                        {
                            File.Delete("Intentos.dat");
                            MessageBox.Show("Archivo de registro eliminado", "Información", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("No hay registro que eliminar");
                        }
                    }
                    this.Close();
                }
                else
                {
                    metodosArchivos.CrearIntento(usuario, tb_Contrasena.Text);
                    MessageBox.Show("La Contraseña introducida es incorrecta.\nSe ha abierto un parte de rastreo para informar al\nusuario del intento de conexión", "Error", MessageBoxButtons.OK);
                    tb_Contrasena.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca la contraseña", "ATENCIÓN", MessageBoxButtons.OK);
            }
        }

        private void tb_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(13))
            {
                bt_Aceptar_Click(null, null);
            }
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            if (opcion != 3)
            {
                menu.Show();
            }
            this.Close();
        }
    }
}