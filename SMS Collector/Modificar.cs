using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace SMS_Collector
{
    public partial class fr_Modificar : Form
    {
        string usuario;
        int contraseña;
        fr_MenuPrincipal menu;
        fr_Visualizar visualizar;
        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;
        SMS datos;
        ArrayList coleccion = new ArrayList();
        int posicion;

        public fr_Modificar(string usuario2, int contraseña2, fr_MenuPrincipal menu2, fr_Visualizar visualizar2)
        {
            usuario = usuario2;
            contraseña = contraseña2;
            menu = menu2;
            visualizar = visualizar2;
            InitializeComponent();
            visualizar.Close();
            cb_Año.SelectedIndex = 0;
            cb_Mes.SelectedIndex = 0;
            cb_Dia.SelectedIndex = 0;
            cb_Hora.SelectedIndex = 0;
            cb_Minuto.SelectedIndex = 0;

            if (File.Exists("Datos.dat"))
            {
                flujo = new FileStream("Datos.dat", FileMode.Open, FileAccess.Read);
                try
                {
                    while (true)
                    {
                        datos = (SMS)serie.Deserialize(flujo);
                        coleccion.Add(datos);
                    }
                }
                catch (SerializationException) { }
                catch (EndOfStreamException) { }
                finally
                {
                    flujo.Close();
                    for (int i = 0; i < coleccion.Count; i++)
                    {
                        datos = (SMS)coleccion[i];
                        list_Resultado.Items.Add(Convert.ToString(datos.DevolverNumero) + " - " + datos.DevolverDia + "/" + datos.DevolverMes + "/" + datos.DevolverAño + " - " + datos.DevolverHora + ":" + datos.DevolverMinuto);
                    }
                    lb_Encontrados.Text = "Encontrados: " + list_Resultado.Items.Count;
                }
            }
            else
            {
                MessageBox.Show("No existe ningún registro", "Atención", MessageBoxButtons.OK);
            }

        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void list_Resultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sw;

            posicion = list_Resultado.SelectedIndex;
            try
            {
                sw = 1;
                datos = (SMS)coleccion[posicion];
            }
            catch (ArgumentOutOfRangeException)
            {
                sw = 0;
            }
            if (sw == 1)
            {
                bt_Modificar.Enabled = true;
                tb_Numero.Text = Convert.ToString(datos.DevolverNumero);
                cb_Año.SelectedItem = datos.DevolverAño;
                cb_Mes.SelectedItem = datos.DevolverMes;
                cb_Dia.SelectedItem = datos.DevolverDia;
                cb_Hora.SelectedItem = datos.DevolverHora;
                cb_Minuto.SelectedItem = datos.DevolverMinuto;
                tb_Mensaje.Text = datos.DevolverMensaje;
            }
        }

        private void tb_Mensaje_TextChanged(object sender, EventArgs e)
        {
            lb_Caracteres.Text = Convert.ToString(tb_Mensaje.Text.Length) + "/1000";
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            int aux = 0;
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
                    aux = Int32.Parse(Convert.ToString(cb_Hora.SelectedItem));
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
                        aux = Int32.Parse(Convert.ToString(cb_Minuto.SelectedItem));
                    }
                    catch (FormatException)
                    {
                        sw = 0;
                    }
                    if ((sw == 1) && (aux >= 0) && (aux <= 59))
                    {
                        datos = new SMS(Convert.ToString(cb_Dia.SelectedItem), Convert.ToString(cb_Mes.SelectedItem), Convert.ToString(cb_Año.SelectedItem), Convert.ToString(cb_Hora.SelectedItem), Convert.ToString(cb_Minuto.SelectedItem), tb_Mensaje.Text, Int32.Parse(tb_Numero.Text), usuario, contraseña);
                        coleccion.RemoveAt(posicion);
                        coleccion.Add(datos);
                        if (File.Exists("Datos.dat"))
                        {
                            flujo = new FileStream("Datos.dat", FileMode.Create, FileAccess.Write);
                            for (int i = 0; i < list_Resultado.Items.Count; i++)
                            {
                                datos = (SMS)coleccion[i];
                                serie.Serialize(flujo, datos);
                            }
                            flujo.Close();
                            MessageBox.Show("Mensaje modificado con éxito", "Información", MessageBoxButtons.OK);
                            bt_Modificar.Enabled = false;
                            Actualizar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Asegúrese de haber escrito correctamente los minutos", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Asegúrese de haber escrito correctamente la hora", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de haber escrito correctamente el número del móvil", "Error", MessageBoxButtons.OK);
            }
        }

        private void Actualizar()
        {
            list_Resultado.Items.Clear();
            coleccion.Clear();
            if (File.Exists("Datos.dat"))
            {
                flujo = new FileStream("Datos.dat", FileMode.Open, FileAccess.Read);
                try
                {
                    while (true)
                    {
                        datos = (SMS)serie.Deserialize(flujo);
                        coleccion.Add(datos);
                    }
                }
                catch (SerializationException) { }
                catch (EndOfStreamException) { }
                finally
                {
                    flujo.Close();
                    for (int i = 0; i < coleccion.Count; i++)
                    {
                        datos = (SMS)coleccion[i];
                        list_Resultado.Items.Add(Convert.ToString(datos.DevolverNumero) + " - " + datos.DevolverDia + "/" + datos.DevolverMes + "/" + datos.DevolverAño + " - " + datos.DevolverHora + ":" + datos.DevolverMinuto);
                    }
                    lb_Encontrados.Text = "Encontrados: " + list_Resultado.Items.Count;
                }
            }
            else
            {
                MessageBox.Show("No existe ningún registro", "Atención", MessageBoxButtons.OK);
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