using System;
using System.IO;
using System.Windows.Forms;

namespace SMS_Collector
{
    public partial class fr_QuienEsModificar : Form
    {
        MetodosArchivos metodosArchivos = new MetodosArchivos();
        fr_QuienEs quienes;
        int movil;

        public fr_QuienEsModificar(string nombre2, string apellidos2, string email2, int movil2, fr_QuienEs quienes2)
        {
            quienes = quienes2;
            movil = movil2;
            InitializeComponent();
            tb_Nombre.Text = nombre2;
            tb_Apellidos.Text = apellidos2;
            tb_Email.Text = email2;
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            quienes.Show();
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            Persona aux = new Persona(tb_Nombre.Text, tb_Apellidos.Text, tb_Email.Text, movil);
            metodosArchivos.QuienEsModificar(aux);
            quienes.Show();
            this.Close();
        }
    }
}