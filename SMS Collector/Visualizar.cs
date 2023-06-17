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
        string usuario;
        int contraseña;
        fr_MenuPrincipal menu;
        fr_Verificacion ver;
        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;
        SMS datos;
        ArrayList coleccion = new ArrayList();

        public fr_Visualizar(string usuario2, int contraseña2, fr_MenuPrincipal menu2, fr_Verificacion ver2)
        {
            usuario = usuario2;
            contraseña = contraseña2;
            menu = menu2;
            ver = ver2;
            InitializeComponent();
            ver.Close();
            if (File.Exists("Datos.dat"))
            {
                flujo = new FileStream("Datos.dat", FileMode.Open, FileAccess.Read);
                try
                {
                    while (true)
                    {
                        int encontrado = 1;
                        int aux;

                        datos = (SMS)serie.Deserialize(flujo);
                        for (int i = 0; i < coleccion.Count; i++)
                        {
                            aux = (int)coleccion[i];
                            if (aux == datos.DevolverNumero)
                            {
                                encontrado = 0;
                                break;
                            }
                        }
                        if (encontrado == 1)
                        {
                            coleccion.Add(datos.DevolverNumero);
                        }
                    }
                }
                catch (SerializationException) { }
                catch (EndOfStreamException) { }
                finally
                {
                    flujo.Close();
                    for (int i = 0; i < coleccion.Count; i++)
                    {
                        cb_Numero.Items.Add(coleccion[i]);
                    }
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
            int aux = 0;
            int sw = 0;

            aux = list_Resultado.SelectedIndex;
            try
            {
                sw = 1;
                datos = (SMS)coleccion[aux];
            }
            catch (ArgumentOutOfRangeException)
            {
                sw = 0;
            }
            if (sw == 1)
            {
                MessageBox.Show("Fecha: " + datos.DevolverDia + "/" + datos.DevolverMes + "/" + datos.DevolverAño + "\nHora: " + datos.DevolverHora + ":" + datos.DevolverMinuto + "\n\n" + datos.DevolverMensaje, "Mensaje", MessageBoxButtons.OK);
            }
        }

        private void cb_Numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aux = 0;

            aux = (int)cb_Numero.SelectedItem;
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
                        if ((usuario == datos.DevolverUsuario) && (contraseña == datos.DevolverContrasena) && (aux == datos.DevolverNumero))
                        {
                            list_Resultado.Items.Add("Fecha: " + datos.DevolverDia + "/" + datos.DevolverMes + "/" + datos.DevolverAño + " Hora: " + datos.DevolverHora + ":" + datos.DevolverMinuto);
                            coleccion.Add(datos);
                        }
                    }
                }
                catch (SerializationException) { }
                catch (EndOfStreamException) { }
                finally
                {
                    flujo.Close();
                    lb_Encontrados.Text = "Encontrados: " + list_Resultado.Items.Count;
                    if (list_Resultado.Items.Count == 0)
                    {
                        list_Resultado.Items.Add("No se han encontrado resultados");
                    }
                }
            }
        }

        private void modificarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Modificar modificar = new fr_Modificar(usuario, contraseña, menu, this);
            modificar.StartPosition = FormStartPosition.CenterScreen;
            modificar.Show();
        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Eliminar eliminar = new fr_Eliminar(usuario, contraseña, menu, this);
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
    }
}