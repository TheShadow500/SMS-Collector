using System;
using System.Windows.Forms;
using System.Collections;

namespace SMS_Collector
{
    public partial class fr_Intentos : Form
    {
        readonly MetodosArchivos metodosArchivos = new MetodosArchivos();
        readonly Configuracion usuario;

        public fr_Intentos(Configuracion usuario2)
        {
            usuario = usuario2;
            ArrayList intentos;

            this.CenterToScreen();
            InitializeComponent();

            intentos = metodosArchivos.ConsultarIntentos();

            for (int i = 0; i < intentos.Count; i++)
            {
                list_Intentos.Items.Add(intentos[i]);
            }
        }

        private void bt_Borrar_Click(object sender, EventArgs e)
        {
            fr_Verificacion verificacion = new fr_Verificacion(usuario, 3, null);
            verificacion.ShowDialog();
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}