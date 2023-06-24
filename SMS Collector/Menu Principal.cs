using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SMS_Collector
{
    public partial class fr_MenuPrincipal : Form
    {
        const string version = "v5.20 Final";
        const string fecha_rev = "24/06/2023";

        MetodosArchivos metodosArchivos = new MetodosArchivos();
        Configuracion usuario;

        public fr_MenuPrincipal()
        {
            usuario = metodosArchivos.CargarUsuario();
            this.CenterToScreen();
            InitializeComponent();
            this.Text = "SMS Collector " + version;
        }

        private void preferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Preferencias preferencias = new fr_Preferencias(usuario);
            preferencias.StartPosition = FormStartPosition.CenterScreen;
            preferencias.ShowDialog();
        }

        private void bt_NuevoSMS_Click(object sender, EventArgs e)
        {
            fr_Verificacion verificacion = new fr_Verificacion(usuario, 1, this);
            this.Hide();
            verificacion.ShowDialog();
        }

        private void bt_VisualizarSMS_Click(object sender, EventArgs e)
        {
            fr_Verificacion verificacion = new fr_Verificacion(usuario, 2, this);
            this.Hide();
            verificacion.ShowDialog();
        }

        private void rastreoIntentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Intentos intentos = new fr_Intentos(usuario);
            intentos.StartPosition = FormStartPosition.CenterScreen;
            intentos.ShowDialog();
        }

        private void ayudaRápidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aún no disponible", "Información", MessageBoxButtons.OK);
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists("ChangeLog.txt"))
            {
                Process.Start("ChangeLog.txt");
            }
            else
            {
                MessageBox.Show("Archivo ChangeLog.txt no disponible", "ATENCIÓN", MessageBoxButtons.OK);
            }
        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("ReadMe.txt"))
            {
                Process.Start("ReadMe.txt");
            }
            else
            {
                MessageBox.Show("Archivo ReadMe.txt no disponible", "ATENCIÓN", MessageBoxButtons.OK);
            }
        }

        private void realizarCopiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metodosArchivos.RealizarCopiaSeguridad("Datos.dat", "Datos2.dat");
        }

        private void restaurarCopiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metodosArchivos.RealizarCopiaSeguridad("Datos2.dat", "Datos.dat");
        }

        private void ordenarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metodosArchivos.OrdenarRegistro();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://theshadow500.blogspot.com");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SMS Collector\nVersión: " + version + "\n\nCreado por: Daniel Amores (TheShadow)\nColaboradora: Luisa María Gutierrez (Luma)\nGrupo Desarrollo: Sinister Software\nPágina Web: http://theshadow500.blogspot.com \n\nÚltima Fecha Revisión:" + fecha_rev + "", "Sobre");
        }

        private void bt_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}