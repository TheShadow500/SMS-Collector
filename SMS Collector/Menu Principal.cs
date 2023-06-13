using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SMS_Collector
{
    public partial class fr_MenuPrincipal : Form
    {
        const string version = "v4.5 Final";

        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;
        Configuracion datos;
        string usuario;
        int contraseña;

        public fr_MenuPrincipal()
        {
            if (File.Exists("Config.cfg"))
            {
                flujo = new FileStream("Config.cfg", FileMode.Open, FileAccess.Read);
                datos = (Configuracion)serie.Deserialize(flujo);
                flujo.Close();
                usuario = datos.DevolverUsuario;
                contraseña = datos.DevolverContraseña;
            }
            else
            {
                MessageBox.Show("Para mayor seguridad, asegúrese de configurar el nombre de usuario y contraseña desde Archivo --> Preferencias", "ATENCION", MessageBoxButtons.OK);
                MessageBox.Show("No hay ningún usuario definido.\nSe han aplicado los valores por defecto:\n\nUsuario: Admin\nContraseña: 12345", "ATENCION", MessageBoxButtons.OK);
                usuario = "Admin";
                contraseña = 12345;
            }
            MessageBox.Show("Cargado el perfil: " + usuario, "Información", MessageBoxButtons.OK);
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            this.Text = "SMS Collector " + version;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SMS Collector\nVersión: " + version + "\n\nCreado por: Daniel Amores (TheShadow)\nColaboradora: Luisa María Gutierrez (Luma)\nGrupo Desarrollo: Sinister Software\nPágina Web: http://theshadow500.blogspot.com \n\nUltima Fecha Revisión: 16/09/2007\nÚltima Fecha Actualización: 12/06/2023", "Sobre");
        }

        private void preferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Preferencias preferencias = new fr_Preferencias(usuario, contraseña);
            preferencias.StartPosition = FormStartPosition.CenterScreen;
            preferencias.ShowDialog();
        }

        private void bt_NuevoSMS_Click(object sender, EventArgs e)
        {
            fr_Verificacion1 verificacion1 = new fr_Verificacion1(usuario, contraseña, this);
            this.Hide();
            verificacion1.StartPosition = FormStartPosition.CenterScreen;
            verificacion1.Show();
        }

        private void rastreoIntentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Intentos intentos = new fr_Intentos(usuario, contraseña);
            intentos.StartPosition = FormStartPosition.CenterScreen;
            intentos.ShowDialog();
        }

        private void bt_VisualizarSMS_Click(object sender, EventArgs e)
        {
            fr_Verificacion2 verificacion2 = new fr_Verificacion2(usuario, contraseña, this);
            this.Hide();
            verificacion2.StartPosition = FormStartPosition.CenterScreen;
            verificacion2.Show();
        }

        private void ayudaRápidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No disponible aun. Preparándola para próxima versión.", "Información", MessageBoxButtons.OK);
        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("ReadMe.txt"))
            {
                Process.Start("ReadMe.txt");
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
            int sw = 0;
            int mes = 0;
            int mes2 = 0;

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
                                if(datos.DevolverMes=="Ene")
                                {
                                    mes = 1;
                                }
                                else if(datos.DevolverMes=="Feb")
                                {
                                    mes = 2;
                                }
                                else if (datos.DevolverMes == "Mar")
                                {
                                    mes = 3;
                                }
                                else if (datos.DevolverMes == "Abr")
                                {
                                    mes = 4;
                                }
                                else if (datos.DevolverMes == "May")
                                {
                                    mes = 5;
                                }
                                else if (datos.DevolverMes == "Jun")
                                {
                                    mes = 6;
                                }
                                else if (datos.DevolverMes == "Jul")
                                {
                                    mes = 7;
                                }
                                else if (datos.DevolverMes == "Ago")
                                {
                                    mes = 8;
                                }
                                else if (datos.DevolverMes == "Sep")
                                {
                                    mes = 9;
                                }
                                else if (datos.DevolverMes == "Oct")
                                {
                                    mes = 10;
                                }
                                else if (datos.DevolverMes == "Nov")
                                {
                                    mes = 11;
                                }
                                else if (datos.DevolverMes == "Dic")
                                {
                                    mes = 12;
                                }
                                if (datos2.DevolverMes == "Ene")
                                {
                                    mes2 = 1;
                                }
                                else if (datos2.DevolverMes == "Feb")
                                {
                                    mes2 = 2;
                                }
                                else if (datos2.DevolverMes == "Mar")
                                {
                                    mes2 = 3;
                                }
                                else if (datos2.DevolverMes == "Abr")
                                {
                                    mes2 = 4;
                                }
                                else if (datos2.DevolverMes == "May")
                                {
                                    mes2 = 5;
                                }
                                else if (datos2.DevolverMes == "Jun")
                                {
                                    mes2 = 6;
                                }
                                else if (datos2.DevolverMes == "Jul")
                                {
                                    mes2 = 7;
                                }
                                else if (datos2.DevolverMes == "Ago")
                                {
                                    mes2 = 8;
                                }
                                else if (datos2.DevolverMes == "Sep")
                                {
                                    mes2 = 9;
                                }
                                else if (datos2.DevolverMes == "Oct")
                                {
                                    mes2 = 10;
                                }
                                else if (datos2.DevolverMes == "Nov")
                                {
                                    mes2 = 11;
                                }
                                else if (datos2.DevolverMes == "Dic")
                                {
                                    mes2 = 12;
                                }
                                if (mes > mes2)
                                {
                                    sw = 1;
                                    coleccion[i] = datos2;
                                    coleccion[i + 1] = datos;
                                }
                                else if (mes == mes2)
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

        private void bt_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}