using System;
using System.Windows.Forms;

namespace SMS_Collector
{
    public partial class fr_NuevoSMS : Form
    {
        MetodosArchivos metodosArchivos = new MetodosArchivos();
        Configuracion usuario;
        fr_MenuPrincipal menu;
        SMS mensaje;

        public fr_NuevoSMS(Configuracion usuario2, fr_MenuPrincipal menu2)
        {
            menu = menu2;
            usuario = usuario2;
            InitializeComponent();
            lb_Usuario.Text = "Usuario: " + usuario.DevolverUsuario;
            cb_Año.SelectedIndex = 0;
            cb_Mes.SelectedIndex = 0;
            cb_Dia.SelectedIndex = 0;
            cb_Hora.SelectedIndex = 0;
            cb_Minuto.SelectedIndex = 0;
        }

        private void tb_Mensaje_TextChanged(object sender, EventArgs e)
        {
            lb_Caracteres.Text = Convert.ToString(tb_Mensaje.Text.Length)+"/1000";
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            int aux;
            bool error = false;

            try
            {
                aux = Int32.Parse(tb_Numero.Text);
            }
            catch (FormatException)
            {
                error = true;
                MessageBox.Show("El número de móvil introducido no es correcto", "ERROR", MessageBoxButtons.OK);
            }

            if(!error)
            {
                mensaje = new SMS(Convert.ToString(cb_Dia.SelectedItem), Convert.ToString(cb_Mes.SelectedItem), Convert.ToString(cb_Año.SelectedItem), Convert.ToString(cb_Hora.SelectedItem), Convert.ToString(cb_Minuto.SelectedItem), tb_Mensaje.Text, Int32.Parse(tb_Numero.Text), usuario.DevolverUsuario, usuario.DevolverContrasena);
                metodosArchivos.AnadirSMS(mensaje);
                MessageBox.Show("Mensaje guardado con éxito", "Información", MessageBoxButtons.OK);
                tb_Mensaje.Clear();
                cb_Hora.SelectedIndex = 0;
                cb_Minuto.SelectedIndex = 0;
            }
        }

        private void cb_Mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = Convert.ToString(cb_Mes.SelectedItem);
            bool sw = false;
            int seleccion = 0;

            switch (opcion)
            {
                case "Ene":
                case "Mar":
                case "May":
                case "Jul":
                case "Ago":
                case "Oct":
                case "Dic":
                    seleccion = cb_Dia.SelectedIndex;
                    cb_Dia.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                    {
                        cb_Dia.Items.Add(i);
                    }
                    cb_Dia.SelectedIndex = seleccion;
                    break;
                case "Abr":
                case "Jun":
                case "Sep":
                case "Nov":
                    if (cb_Dia.SelectedIndex < 30)
                    {
                        sw = true;
                        seleccion = cb_Dia.SelectedIndex;
                    }
                    cb_Dia.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                    {
                        cb_Dia.Items.Add(i);
                    }
                    if(sw)
                    {
                        cb_Dia.SelectedIndex = seleccion;
                    }
                    else
                    {
                        cb_Dia.SelectedIndex = 0;
                    }
                    break;
                case "Feb":
                    int limite = 28;
                    if (Convert.ToInt32(cb_Año.SelectedItem) % 4 == 0)
                    {
                        limite = 29;
                    }
                    if (cb_Dia.SelectedIndex < limite)
                    {
                        sw = true;
                        seleccion = cb_Dia.SelectedIndex;
                    }
                    cb_Dia.Items.Clear();
                    for (int i = 1; i <= limite; i++)
                    {
                        cb_Dia.Items.Add(i);
                    }
                    if(sw)
                    {
                        cb_Dia.SelectedIndex = seleccion;
                    }
                    else
                    {
                        cb_Dia.SelectedIndex = 0;
                    }
                    break;
            }
        }

        private void cb_Año_SelectedIndexChanged(object sender, EventArgs e)
        {
            int limite = 31;
            int seleccion = 0;
            bool sw = false;

            if ((Convert.ToInt32(cb_Año.SelectedItem) % 4 == 0) && cb_Mes.SelectedIndex == 1)
            {
                limite = 29;
            }
            else if ((Convert.ToInt32(cb_Año.SelectedItem) % 4 != 0) && cb_Mes.SelectedIndex == 1)
            {
                limite = 28;
            }

            if (cb_Dia.SelectedIndex < limite)
            {
                seleccion = cb_Dia.SelectedIndex;
                sw = true;
            }
            cb_Dia.Items.Clear();
            for (int i = 1; i <= limite; i++)
            {
                cb_Dia.Items.Add(i);
            }
            if (sw)
            {
                cb_Dia.SelectedIndex = seleccion;
            }
            else
            {
                cb_Dia.SelectedIndex = 0;
            }
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}