using System;
using System.Windows.Forms;

namespace SMS_Collector
{
    public partial class fr_Preferencias : Form
    {
        MetodosArchivos metodosArchivo = new MetodosArchivos();
        Configuracion datos;

        public fr_Preferencias(Configuracion datos2)
        {
            datos = datos2;
            InitializeComponent();

            tb_Usuario.Text = datos2.DevolverUsuario;
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (tb_Contrasena.Text.Length >= 5)
            {
                if (Int32.Parse(tb_Anterior.Text) == datos.DevolverContrasena)
                {
                    datos.AsignarUsuario(tb_Usuario.Text);
                    datos.AsignarContraseña(Int32.Parse(tb_Contrasena.Text));
                    metodosArchivo.ModificarContrasena(datos);
                }
                else
                {
                    MessageBox.Show("La contraseña anterior no es correcta", "Error", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                MessageBox.Show("Asegúrese de que la contraseña este compuesta por un mínimo de 5 dígitos", "Error", MessageBoxButtons.OK);
            }
        }

        private void tb_Contrasena_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_Anterior_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}