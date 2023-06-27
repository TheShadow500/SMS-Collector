using System;
using System.Windows.Forms;
using System.Collections;

namespace SMS_Collector
{
    public partial class fr_Eliminar : Form
    {
        MetodosArchivos metodosArchivos = new MetodosArchivos();
        fr_MenuPrincipal menu;
        fr_Visualizar visualizar;
        SMS datos;
        ArrayList coleccion = new ArrayList();
        int posicion;

        public fr_Eliminar(Configuracion usuario2, fr_MenuPrincipal menu2, fr_Visualizar visualizar2)
        {
            menu = menu2;
            visualizar = visualizar2;
            InitializeComponent();
            visualizar.Close();

            coleccion = metodosArchivos.CargarRegistroCompleto();
            for (int i = 0; i < coleccion.Count; i++)
            {
                datos = (SMS)coleccion[i];
                list_Resultado.Items.Add(Convert.ToString(datos.DevolverNumero) + " - " + datos.DevolverDia + "/" + datos.DevolverMes + "/" + datos.DevolverAño + " - " + datos.DevolverHora + ":" + datos.DevolverMinuto);
            }
            lb_Encontrados.Text = "Encontrados: " + list_Resultado.Items.Count;
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void list_Resultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool encontrado;

            posicion = list_Resultado.SelectedIndex;
            try
            {
                encontrado = true;
                datos = (SMS)coleccion[posicion];
            }
            catch (ArgumentOutOfRangeException)
            {
                encontrado = false;
            }
            if (encontrado)
            {
                bt_Eliminar.Enabled = true;
                lb_Numero.Text="Nº Móvil: "+ Convert.ToString(datos.DevolverNumero);
                lb_Fecha.Text = "Fecha: " + datos.DevolverDia + "/" + datos.DevolverMes + "/" + datos.DevolverAño;
                lb_Hora.Text = "Hora: " + datos.DevolverHora + ":" + datos.DevolverMinuto;
                tb_Mensaje.Text = datos.DevolverMensaje;
            }
        }

        private void tb_Mensaje_TextChanged(object sender, EventArgs e)
        {
            lb_Caracteres.Text = Convert.ToString(tb_Mensaje.Text.Length) + "/1000";
        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult seleccion = MessageBox.Show("¿Está seguro de querer eliminar el mensaje seleccionado?", "ATENCIÓN", MessageBoxButtons.YesNo);
            if (seleccion == DialogResult.Yes)
            {
                coleccion.RemoveAt(posicion);
                metodosArchivos.CrearArchivo(coleccion);
                MessageBox.Show("Mensaje eliminado con éxito", "Información", MessageBoxButtons.OK);
                Actualizar();
            }
        }

        private void Actualizar()
        {
            bt_Eliminar.Enabled = false;
            lb_Numero.Text = "Nº Móvil:";
            lb_Fecha.Text = "Fecha:";
            lb_Hora.Text = "Hora:";
            tb_Mensaje.Clear();
            list_Resultado.Items.Clear();
            coleccion.Clear();
            coleccion = metodosArchivos.CargarRegistroCompleto();
            for (int i = 0; i < coleccion.Count; i++)
            {
                datos = (SMS)coleccion[i];
                list_Resultado.Items.Add(Convert.ToString(datos.DevolverNumero) + " - " + datos.DevolverDia + "/" + datos.DevolverMes + "/" + datos.DevolverAño + " - " + datos.DevolverHora + ":" + datos.DevolverMinuto);
            }
            lb_Encontrados.Text = "Encontrados: " + list_Resultado.Items.Count;
        }
    }
}