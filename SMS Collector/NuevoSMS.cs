using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SMS_Collector
{
    public partial class fr_NuevoSMS : Form
    {
        string usuario;
        int contraseña;
        fr_MenuPrincipal menu;
        fr_Verificacion1 ver;
        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;
        SMS mensaje;

        public fr_NuevoSMS(string usuario2, int contraseña2, fr_MenuPrincipal menu2, fr_Verificacion1 ver2)
        {
            usuario = usuario2;
            contraseña = contraseña2;
            menu = menu2;
            ver = ver2;
            InitializeComponent();
            ver.Close();
            lb_Usuario.Text = "Usuario: " + usuario;
            cb_Dia.SelectedIndex = 0;
            cb_Mes.SelectedIndex = 0;
            cb_Año.SelectedIndex = 0;
            cb_Hora.SelectedIndex = 0;
            cb_Minuto.SelectedIndex = 0;
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
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
                mensaje = new SMS(Convert.ToString(cb_Dia.SelectedItem), Convert.ToString(cb_Mes.SelectedItem), Convert.ToString(cb_Año.SelectedItem), Convert.ToString(cb_Hora.SelectedItem), Convert.ToString(cb_Minuto.SelectedItem), tb_Mensaje.Text, Int32.Parse(tb_Numero.Text), usuario, contraseña);
                if(File.Exists("Datos.dat"))
                {
                    flujo = new FileStream("Datos.dat", FileMode.Append, FileAccess.Write);
                }
                else
                {
                    flujo = new FileStream("Datos.dat", FileMode.Create, FileAccess.Write);
                }
                serie.Serialize(flujo, mensaje);
                flujo.Close();
                MessageBox.Show("Mensaje guardado con éxito", "Información", MessageBoxButtons.OK);
                tb_Mensaje.Clear();
                cb_Hora.SelectedIndex = 0;
                cb_Minuto.SelectedIndex = 0;
            }
        }

        private void cb_Mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = Convert.ToString(cb_Mes.SelectedItem);

            switch (opcion)
            {
                case "Ene":
                case "Mar":
                case "May":
                case "Jul":
                case "Ago":
                case "Oct":
                case "Dic":
                    cb_Dia.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                    {
                        cb_Dia.Items.Add(i);
                    }
                    break;
                case "Abr":
                case "Jun":
                case "Sep":
                case "Nov":
                    cb_Dia.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                    {
                        cb_Dia.Items.Add(i);
                    }
                    break;
                case "Feb":
                    int limite = 28;
                    cb_Dia.Items.Clear();
                    if (Convert.ToInt32(cb_Año.SelectedItem) % 4 == 0)
                    {
                        limite = 29;
                    }
                    for (int i = 1; i <= limite; i++)
                    {
                        cb_Dia.Items.Add(i);
                    }
                    break;
            }
            cb_Dia.SelectedIndex = 0;
        }

        private void cb_Año_SelectedIndexChanged(object sender, EventArgs e)
        {
            int limite = 31;

            if ((Convert.ToInt32(cb_Año.SelectedItem) % 4 == 0) && Convert.ToString(cb_Mes.SelectedItem) == "Feb")
            {
                limite = 29;
            }
            else if ((Convert.ToInt32(cb_Año.SelectedItem) % 4 != 0) && Convert.ToString(cb_Mes.SelectedItem) == "Feb")
            {
                limite = 28;
            }

            cb_Dia.Items.Clear();
            for (int i = 1; i <= limite; i++)
            {
                cb_Dia.Items.Add(i);
            }
            cb_Dia.SelectedIndex = 0;
        }
    }
}