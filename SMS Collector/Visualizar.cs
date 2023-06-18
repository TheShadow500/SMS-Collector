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
        string usuario;
        int contrasena;
        fr_MenuPrincipal menu;
        fr_Verificacion verificacion;
        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;
        SMS datos;
        ArrayList coleccion = new ArrayList();

        public fr_Visualizar(Configuracion usuario2, fr_MenuPrincipal menu2, fr_Verificacion verificacion2)
        {
            usuario = usuario2.DevolverUsuario;
            contrasena = usuario2.DevolverContrasena;
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

        private void bt_Volver_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close();
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
                MessageBox.Show("Fecha: " + datos.DevolverDia + "/" + datos.DevolverMes + "/" + datos.DevolverA�o + "\nHora: " + datos.DevolverHora + ":" + datos.DevolverMinuto + "\n\n" + datos.DevolverMensaje, "Mensaje", MessageBoxButtons.OK);
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
                        if ((usuario == datos.DevolverUsuario) && (contrasena == datos.DevolverContrasena) && (aux == datos.DevolverNumero))
                        {
                            list_Resultado.Items.Add("Fecha: " + datos.DevolverDia + "/" + datos.DevolverMes + "/" + datos.DevolverA�o + " Hora: " + datos.DevolverHora + ":" + datos.DevolverMinuto);
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
            fr_Modificar modificar = new fr_Modificar(usuario, contrasena, menu, this);
            modificar.StartPosition = FormStartPosition.CenterScreen;
            modificar.Show();
        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Eliminar eliminar = new fr_Eliminar(usuario, contrasena, menu, this);
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
                    seleccion = MessageBox.Show("No existe informaci�n sobre el n�mero " + cb_Numero.SelectedText + ". �Desea a�adirla?", "Atenci�n", MessageBoxButtons.YesNo);
                    if (seleccion == DialogResult.Yes)
                    {
                        fr_A�adirContacto a�adir = new fr_A�adirContacto(cb_Numero.SelectedText, this);
                        a�adir.StartPosition = FormStartPosition.CenterScreen;
                        a�adir.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Aseg�rese de tener un n�mero seleccionado de manera activa", "Atenci�n", MessageBoxButtons.OK);
            }
        }
    }
}