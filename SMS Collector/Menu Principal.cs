using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SMS_Collector
{
    public partial class fr_MenuPrincipal : Form
    {
        const string version = "v4.9 Final";
        const string fecha_rev = "16/06/2023";

        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;
        MetodosArchivos metodosArchivos = new MetodosArchivos();
        Configuracion usuario;

        public fr_MenuPrincipal()
        {
            /* Carga de Datos de Usuario */
            usuario = metodosArchivos.CargarUsuario();

            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SMS Collector " + version;
        }

        private void preferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Preferencias preferencias = new fr_Preferencias(usuario);
            preferencias.StartPosition = FormStartPosition.CenterScreen;
            preferencias.ShowDialog();
        }

        private void bt_NuevoSMS_Click(object sender, EventArgs e)
        {
            fr_Verificacion1 verificacion1 = new fr_Verificacion1(usuario, 1, this);
            this.Hide();
            verificacion1.StartPosition = FormStartPosition.CenterScreen;
            verificacion1.ShowDialog();
        }

        private void bt_VisualizarSMS_Click(object sender, EventArgs e)
        {
            fr_Verificacion1 verificacion1 = new fr_Verificacion1(usuario, 2, this);
            this.Hide();
            verificacion1.StartPosition = FormStartPosition.CenterScreen;
            verificacion1.ShowDialog();
        }

        private void rastreoIntentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Intentos intentos = new fr_Intentos(usuario);
            intentos.StartPosition = FormStartPosition.CenterScreen;
            intentos.ShowDialog();
        }

        private void ayudaRápidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aún no disponible", "Información", MessageBoxButtons.OK);
        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("ReadMe.txt"))
            {
                Process.Start("ReadMe.txt");
            }
            else
            {
                MessageBox.Show("Archivo ReadMe.txt no disponible", "ATENCIÓN", MessageBoxButtons.OK);
            }
        }

        private void realizarCopiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream flujo2;
            SMS aux;

            if (File.Exists("Datos.dat"))
            {
                flujo = new FileStream("Datos.dat", FileMode.Open, FileAccess.Read);
                flujo2 = new FileStream("Datos2.dat", FileMode.Create, FileAccess.Write);
                try
                {
                    while (true)
                    {
                        aux = (SMS)serie.Deserialize(flujo);
                        serie.Serialize(flujo2, aux);
                    }
                }
                catch (EndOfStreamException) { }
                catch (SerializationException) { }
                finally
                {
                    flujo.Close();
                    flujo2.Close();
                    MessageBox.Show("Copia de Seguridad realizada con éxito", "ATENCIÓN", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No existe ningun fichero de datos", "ATENCIÓN", MessageBoxButtons.OK);
            }
        }

        private void restaurarCopiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream flujo2;
            SMS aux;

            if (File.Exists("Datos2.dat"))
            {
                flujo = new FileStream("Datos2.dat", FileMode.Open, FileAccess.Read);
                flujo2 = new FileStream("Datos.dat", FileMode.Create, FileAccess.Write);
                try
                {
                    while (true)
                    {
                        aux = (SMS)serie.Deserialize(flujo);
                        serie.Serialize(flujo2, aux);
                    }
                }
                catch (EndOfStreamException) { }
                catch (SerializationException) { }
                finally
                {
                    flujo.Close();
                    flujo2.Close();
                    MessageBox.Show("Copia de Seguridad restaurada con éxito", "ATENCIÓN", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No existe ninguna Copia de Seguridad para restaurar", "ATENCIÓN", MessageBoxButtons.OK);
            }
        }

        private void ordenarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList coleccion = new ArrayList();
            SMS datos;
            SMS datos2;
            int sw;

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
                    do
                    {
                        sw = 0;
                        for (int i = 0; i < coleccion.Count-1; i++)
                        {
                            datos = (SMS)coleccion[i];
                            datos2 = (SMS)coleccion[i + 1];
                            if (Int32.Parse(datos.DevolverAño) > Int32.Parse(datos2.DevolverAño))
                            {
                                sw = 1;
                                coleccion[i] = datos2;
                                coleccion[i + 1] = datos;
                            }
                            else if (Int32.Parse(datos.DevolverAño) == Int32.Parse(datos2.DevolverAño))
                            {
                                List<string> meses = new List<string>()
                                {
                                    "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic"
                                };

                                if(meses.IndexOf(datos.DevolverMes) > meses.IndexOf(datos2.DevolverMes))
                                {
                                    sw = 1;
                                    coleccion[i] = datos2;
                                    coleccion[i + 1] = datos;
                                }
                                else if (meses.IndexOf(datos.DevolverMes) == meses.IndexOf(datos2.DevolverMes))
                                {
                                    if (Int32.Parse(datos.DevolverDia) > Int32.Parse(datos2.DevolverDia))
                                    {
                                        sw = 1;
                                        coleccion[i] = datos2;
                                        coleccion[i + 1] = datos;
                                    }
                                    else if (Int32.Parse(datos.DevolverDia) == Int32.Parse(datos2.DevolverDia))
                                    {
                                        if (Int32.Parse(datos.DevolverHora) > Int32.Parse(datos2.DevolverHora))
                                        {
                                            sw = 1;
                                            coleccion[i] = datos2;
                                            coleccion[i + 1] = datos;
                                        }
                                        else if (Int32.Parse(datos.DevolverHora) == Int32.Parse(datos2.DevolverHora))
                                        {
                                            if (Int32.Parse(datos.DevolverMinuto) > Int32.Parse(datos2.DevolverMinuto))
                                            {
                                                sw = 1;
                                                coleccion[i] = datos2;
                                                coleccion[i + 1] = datos;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    } while (sw == 1);
                    flujo = new FileStream("Datos.dat", FileMode.Create, FileAccess.Write);
                    for (int i = 0; i < coleccion.Count; i++)
                    {
                        datos = (SMS)coleccion[i];
                        serie.Serialize(flujo, datos);
                    }
                    flujo.Close();
                    MessageBox.Show("Registro ordenado con éxito", "Información", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No existe ningún registro", "Atención", MessageBoxButtons.OK);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://theshadow500.blogspot.com");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SMS Collector\nVersión: " + version + "\n\nCreado por: Daniel Amores (TheShadow)\nColaboradora: Luisa María Gutierrez (Luma)\nGrupo Desarrollo: Sinister Software\nPágina Web: http://theshadow500.blogspot.com \n\nÚltima Fecha Revisión:" + fecha_rev + "", "Sobre");
        }

        private void bt_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}