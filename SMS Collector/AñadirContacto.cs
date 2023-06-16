using System;
using System.Windows.Forms;

namespace SMS_Collector
{
    public partial class fr_AñadirContacto : Form
    {
        MetodosArchivos metodosArchivos = new MetodosArchivos();
        int movil;
        fr_Visualizar visualizar;

        public fr_AñadirContacto(string movil2, fr_Visualizar visualizar2)
        {
            movil = Convert.ToInt32(movil2);
            visualizar = visualizar2;
            InitializeComponent();
            lb_Movil.Text = "Nº de Móvil: " + Convert.ToString(movil);
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            if ((tb_Nombre.Text.Length > 0) && (tb_Apellidos.Text.Length > 0) && (tb_Email.Text.Length > 0))
            {
                Persona persona = new Persona(tb_Nombre.Text, tb_Apellidos.Text, tb_Email.Text, (Int32)movil);
                metodosArchivos.AnadirContacto(persona);
                visualizar.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Asegúrese de rellenar todos los campos", "Atención", MessageBoxButtons.OK);
            }
        }
        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            visualizar.Show();
        }
    }
}