using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SMS_Collector
{
    public partial class fr_NuevoSMS : Form
    {
        string usuario;
        int contrase�a;
        fr_MenuPrincipal menu;
        fr_Verificacion1 ver;
        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;
        SMS mensaje;

        public fr_NuevoSMS(string usuario2, int contrase�a2, fr_MenuPrincipal menu2, fr_Verificacion1 ver2)
        {
            usuario = usuario2;
            contrase�a = contrase�a2;
            menu = menu2;
            ver = ver2;
            InitializeComponent();
            ver.Close();
            lb_Usuario.Text = "Usuario: " + usuario;
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
            int aux=0;
            int sw;

            try
            {
                sw = 1;
                aux = Int32.Parse(tb_Numero.Text);
            }
            catch (FormatException)
            {
                sw = 0;
            }
            if ((sw == 1) && (aux >= 600000000) && (aux <= 699999999))
            {
                try
                {
                    sw = 1;
                    aux = Int32.Parse(tb_Hora.Text);
                }
                catch (FormatException)
                {
                    sw = 0;
                }
                if ((sw == 1) && (aux >= 0) && (aux <= 24))
                {
                    try
                    {
                        sw = 1;
                        aux = Int32.Parse(tb_Minuto.Text);
                    }
                    catch (FormatException)
                    {
                        sw = 0;
                    }
                    if ((sw == 1) && (aux >= 0) && (aux <= 59))
                    {
                        if ((cb_Dia.SelectedItem != null) && (cb_Mes.SelectedItem != null) && (cb_A�o.SelectedItem != null))
                        {
                            mensaje = new SMS(Convert.ToString(cb_Dia.SelectedItem), Convert.ToString(cb_Mes.SelectedItem), Convert.ToString(cb_A�o.SelectedItem), tb_Hora.Text, tb_Minuto.Text, tb_Mensaje.Text, Int32.Parse(tb_Numero.Text), usuario, contrase�a);
                            if (File.Exists("Datos.dat"))
                            {
                                flujo = new FileStream("Datos.dat", FileMode.Append, FileAccess.Write);
                            }
                            else
                            {
                                flujo = new FileStream("Datos.dat", FileMode.Create, FileAccess.Write);
                            }
                            serie.Serialize(flujo, mensaje);
                            flujo.Close();
                            MessageBox.Show("Mensaje guardado con �xito", "Informaci�n", MessageBoxButtons.OK);
                            tb_Mensaje.Clear();
                            tb_Hora.Clear();
                            tb_Minuto.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Asegurese de haber seleccionado correctamente la fecha\nNo puede ser introducida v�a teclado", "Error", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aseg�rese de haber escrito correctamente los minutos", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Aseg�rese de haber escrito correctamente la hora", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Aseg�rese de haber escrito correctamente el n�mero del m�vil", "Error", MessageBoxButtons.OK);
            }
        }
    }
}