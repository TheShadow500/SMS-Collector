using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace SMS_Collector
{
    public partial class fr_Visualizar : Form
    {
        MetodosArchivos metodosArchivos = new MetodosArchivos();
        Configuracion usuario;
        fr_MenuPrincipal menu;
        fr_Verificacion verificacion;
        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;
        SMS datos;
        ArrayList coleccion = new ArrayList();

        public fr_Visualizar(Configuracion usuario2, fr_MenuPrincipal menu2, fr_Verificacion verificacion2)
        {
            usuario = usuario2;
            menu = menu2;
            verificacion = verificacion2;
            InitializeComponent();
            verificacion.Close();
            coleccion = metodosArchivos.CargarRegistro();
            for (int i = 0; i < coleccion.Count; i++)
            {
                cb_Numero.Items.Add(coleccion[i]);
            }
        }

        private void list_Resultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aux;
            bool error;

            aux = list_Resultado.SelectedIndex;
            try
            {
                error = false;
                datos = (SMS)coleccion[aux];
            }
            catch (ArgumentOutOfRangeException)
            {
                error = true;
            }
            if (!error)
            {
                MessageBox.Show("Fecha: " + datos.DevolverDia + "/" + datos.DevolverMes + "/" + datos.DevolverAño + "\nHora: " + datos.DevolverHora + ":" + datos.DevolverMinuto + "\n\n" + datos.DevolverMensaje, "Mensaje", MessageBoxButtons.OK);
            }
        }

        private void cb_Numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            coleccion = metodosArchivos.CargarHistorial(usuario, (int)cb_Numero.SelectedItem);
            list_Resultado.Items.Clear();
            for (int i = 0; i < coleccion.Count; i++)
            {
                datos = (SMS)coleccion[i];
                list_Resultado.Items.Add("Fecha: " + datos.DevolverDia + "/" + datos.DevolverMes + "/" + datos.DevolverAño + " Hora: " + datos.DevolverHora + ":" + datos.DevolverMinuto);
            }
            lb_Encontrados.Text = "Encontrados: " + list_Resultado.Items.Count;
            if (list_Resultado.Items.Count == 0)
            {
                list_Resultado.Items.Add("No se han encontrado resultados");
            }
        }

        private void modificarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Modificar modificar = new fr_Modificar(usuario, menu, this);
            modificar.StartPosition = FormStartPosition.CenterScreen;
            modificar.Show();
        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Eliminar eliminar = new fr_Eliminar(usuario, menu, this);
            eliminar.StartPosition = FormStartPosition.CenterScreen;
            eliminar.Show();
        }

        private void lb_QuienEs_MouseEnter(object sender, EventArgs e)
        {
            lb_QuienEs.ForeColor = System.Drawing.Color.Yellow;
        }

        private void lb_QuienEs_MouseLeave(object sender, EventArgs e)
        {
            lb_QuienEs.ForeColor = System.Drawing.Color.Orange;
        }

        private void lb_QuienEs_Click(object sender, EventArgs e)
        {
            if ((cb_Numero.SelectedItem != null) && (cb_Numero.SelectedText.Length == 9))
            {
                int encontrados = 1;
                DialogResult seleccion;

                if (File.Exists("Numeros.dat"))
                {
                    FileStream flujo2 = new FileStream("Numeros.dat", FileMode.Open, FileAccess.Read);
                    try
                    {
                        while (true)
                        {
                            Persona aux = (Persona)serie.Deserialize(flujo2);
                            if (Convert.ToString(aux.DevolverMovil).CompareTo(cb_Numero.SelectedText) == 0)
                            {
                                encontrados = 1;
                                fr_QuienEs quienes = new fr_QuienEs(aux.DevolverNombre, aux.DevolverApellidos, aux.DevolverEmail, aux.DevolverMovil, this);
                                quienes.StartPosition = FormStartPosition.CenterScreen;
                                quienes.Show();
                                this.Hide();
                                break;
                            }
                            else
                            {
                                encontrados = 0;
                            }
                        }
                    }
                    catch (SerializationException) { }
                    catch (EndOfStreamException) { }
                    finally
                    {
                        flujo2.Close();
                    }
                }
                else
                {
                    encontrados = 0;
                }
                if (encontrados == 0)
                {
                    seleccion = MessageBox.Show("No existe información sobre el número " + cb_Numero.SelectedText + ". ¿Desea añadirla?", "Atención", MessageBoxButtons.YesNo);
                    if (seleccion == DialogResult.Yes)
                    {
                        fr_AñadirContacto añadir = new fr_AñadirContacto(cb_Numero.SelectedText, this);
                        añadir.StartPosition = FormStartPosition.CenterScreen;
                        añadir.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de tener un número seleccionado de manera activa", "Atención", MessageBoxButtons.OK);
            }
        }

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close();
        }
    }
}