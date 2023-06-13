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
    public partial class fr_Eliminar : Form
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

        public fr_Eliminar(string usuario2, int contraseña2, fr_MenuPrincipal menu2, fr_Visualizar visualizar2)
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
            DialogResult seleccion;

            seleccion = MessageBox.Show("¿Esta seguro de querer eliminar el mensaje seleccionado?", "Atención", MessageBoxButtons.YesNo);
            if (seleccion == DialogResult.Yes)
            {
                coleccion.RemoveAt(posicion);
                flujo = new FileStream("Datos.dat", FileMode.Create, FileAccess.Write);
                for (int i = 0; i < coleccion.Count; i++)
                {
                    datos = (SMS)coleccion[i];
                    serie.Serialize(flujo, datos);
                }
                flujo.Close();
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