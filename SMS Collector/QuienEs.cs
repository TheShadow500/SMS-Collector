using System;
using System.Windows.Forms;

namespace SMS_Collector
{
    public partial class fr_QuienEs : Form
    {
        Persona aux;
        fr_Visualizar visualizar;

        public fr_QuienEs(string nombre, string apellidos, string email, int movil, fr_Visualizar visualizar2)
        {
            aux = new Persona(nombre, apellidos, email, movil);
            visualizar = visualizar2;
            InitializeComponent();
            lb_Nombre.Text = "Nombre: " + aux.DevolverNombre;
            lb_Apellidos.Text = "Apellidos: " + aux.DevolverApellidos;
            lb_Email.Text = "e-Mail: " + aux.DevolverEmail;
            lb_Movil.Text = "Nº de Móvil: " + aux.DevolverMovil;
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
            visualizar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fr_QuienEsModificar quienesmodificar = new fr_QuienEsModificar(aux.DevolverNombre, aux.DevolverApellidos, aux.DevolverEmail, aux.DevolverMovil, this);
            quienesmodificar.StartPosition = FormStartPosition.CenterScreen;
            quienesmodificar.Show();
            this.Hide();
        }
    }
}