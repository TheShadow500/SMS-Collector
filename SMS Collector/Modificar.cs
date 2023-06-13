using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            int sw = 0;

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
                cb_Dia.SelectedItem = datos.DevolverDia;
                cb_Mes.SelectedItem = datos.DevolverMes;
                cb_Año.SelectedItem = datos.DevolverAño;
                tb_Hora.Text = datos.DevolverHora;
                tb_Minuto.Text = datos.DevolverMinuto;
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
            int sw = 0;

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
                        datos = new SMS(Convert.ToString(cb_Dia.SelectedItem), Convert.ToString(cb_Mes.SelectedItem), Convert.ToString(cb_Año.SelectedItem), tb_Hora.Text, tb_Minuto.Text, tb_Mensaje.Text, Int32.Parse(tb_Numero.Text), usuario, contraseña);
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
    }
}