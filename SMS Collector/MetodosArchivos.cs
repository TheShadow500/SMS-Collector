using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SMS_Collector
{
    class MetodosArchivos
    {
        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;
        FileStream flujo2;

        public Configuracion CargarUsuario()
        {
            Configuracion datos;

            if (File.Exists("Config.cfg"))
            {
                flujo = new FileStream("Config.cfg", FileMode.Open, FileAccess.Read);
                datos = (Configuracion)serie.Deserialize(flujo);
                flujo.Close();
            }
            else
            {
                datos = new Configuracion("Admin", 12345);
                MessageBox.Show("No hay ningún usuario creado.\nSe han aplicado los valores por defecto:\n\nUsuario: Admin\nContraseña: 12345", "ATENCIÓN", MessageBoxButtons.OK);
                MessageBox.Show("Para mayor seguridad, asegúrese de configurar el nombre de usuario y la contraseña desde Archivo -> Preferencias", "ATENCIÓN", MessageBoxButtons.OK);
            }

            MessageBox.Show("Cargado el perfil: " + datos.DevolverUsuario, "Información", MessageBoxButtons.OK);

            return datos;
        }

        public void ModificarContrasena(Configuracion datos)
        {
            flujo = new FileStream("Config.cfg", FileMode.Create, FileAccess.Write);
            serie.Serialize(flujo, datos);
            flujo.Close();

            MessageBox.Show("Modificado con éxito.\nDebe reiniciar el programa para que los cambios tengan efecto", "Información", MessageBoxButtons.OK);
        }

        public void AnadirContacto(Persona persona)
        {
            if(File.Exists("Numeros.dat"))
            {
                flujo = new FileStream("Numeros.dat", FileMode.Append, FileAccess.Write);
            }
            else
            {
                flujo = new FileStream("Numeros.dat", FileMode.Create, FileAccess.Write);
            }

            serie.Serialize(flujo, persona);
            flujo.Close();
            MessageBox.Show("Perfil guardado con éxito", "Información", MessageBoxButtons.OK);
        }

        public ArrayList ConsultarIntentos()
        {
            ArrayList intentos = new ArrayList();

            if (File.Exists("Intentos.dat"))
            {
                flujo = new FileStream("Intentos.dat", FileMode.Open, FileAccess.Read);

                try
                {
                    while (true)
                    {
                        intentos.Add((String)serie.Deserialize(flujo));
                    }
                }
                catch (SerializationException) { }
                catch (EndOfStreamException) { }
                finally
                {
                    flujo.Close();
                }
            }
            else
            {
                MessageBox.Show("No hay ningún registro", "Información", MessageBoxButtons.OK);
            }

            return intentos;
        }

        public void CrearIntento(Configuracion usuario, string contrasena)
        {
            string error;

            error = Convert.ToString("Usuario: " + usuario.DevolverUsuario + " - " + DateTime.Now + " - Contraseña: " + contrasena);

            if (File.Exists("Intentos.dat"))
            {
                flujo = new FileStream("Intentos.dat", FileMode.Append, FileAccess.Write);
            }
            else
            {
                flujo = new FileStream("Intentos.dat", FileMode.Create, FileAccess.Write);
            }
            serie.Serialize(flujo, error);
            flujo.Close();
        }

        public void RealizarCopiaSeguridad(string archivoorigen, string archivodestino)
        {
            if (File.Exists(archivoorigen))
            {
                flujo = new FileStream(archivoorigen, FileMode.Open, FileAccess.Read);
                flujo2 = new FileStream(archivodestino, FileMode.Create, FileAccess.Write);
                try
                {
                    while (true)
                    {
                        serie.Serialize(flujo2, (SMS)serie.Deserialize(flujo));
                    }
                }
                catch (EndOfStreamException) { }
                catch (SerializationException) { }
                finally
                {
                    flujo.Close();
                    flujo2.Close();
                    if (archivoorigen.CompareTo("Datos.dat") == 0)
                    {
                        MessageBox.Show("Copia de Seguridad realizada con éxito", "ATENCIÓN", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Copia de Seguridad restaurada con éxito", "ATENCIÓN", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                if (archivoorigen.CompareTo("Datos.dat") == 0)
                {
                    MessageBox.Show("No existe ningun fichero de datos", "ATENCIÓN", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No existe ninguna Copia de Seguridad para restaurar", "ATENCIÓN", MessageBoxButtons.OK);
                }
            }
        }

        public void OrdenarRegistro()
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
                        for (int i = 0; i < coleccion.Count - 1; i++)
                        {
                            datos = (SMS)coleccion[i];
                            datos2 = (SMS)coleccion[i + 1];
                            if (Int32.Parse(datos.DevolverAño) > Int32.Parse(datos2.DevolverAño))
                            {
                                sw = 1;
                            }
                            else if (Int32.Parse(datos.DevolverAño) == Int32.Parse(datos2.DevolverAño))
                            {
                                List<string> meses = new List<string>()
                                {
                                    "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic"
                                };

                                if (meses.IndexOf(datos.DevolverMes) > meses.IndexOf(datos2.DevolverMes))
                                {
                                    sw = 1;
                                }
                                else if (meses.IndexOf(datos.DevolverMes) == meses.IndexOf(datos2.DevolverMes))
                                {
                                    if (Int32.Parse(datos.DevolverDia) > Int32.Parse(datos2.DevolverDia))
                                    {
                                        sw = 1;
                                    }
                                    else if (Int32.Parse(datos.DevolverDia) == Int32.Parse(datos2.DevolverDia))
                                    {
                                        if (Int32.Parse(datos.DevolverHora) > Int32.Parse(datos2.DevolverHora))
                                        {
                                            sw = 1;
                                        }
                                        else if (Int32.Parse(datos.DevolverHora) == Int32.Parse(datos2.DevolverHora))
                                        {
                                            if (Int32.Parse(datos.DevolverMinuto) > Int32.Parse(datos2.DevolverMinuto))
                                            {
                                                sw = 1;
                                            }
                                        }
                                    }
                                }
                            }
                            if(sw==1)
                            {
                                coleccion[i] = datos2;
                                coleccion[i + 1] = datos;
                            }
                        }
                    } while (sw == 1);
                    CrearArchivo(coleccion);
                    MessageBox.Show("Registro ordenado con éxito", "Información", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No existe ningún registro", "Atención", MessageBoxButtons.OK);
            }
        }

        public void CrearArchivo(ArrayList coleccion)
        {
            flujo = new FileStream("Datos.dat", FileMode.Create, FileAccess.Write);
            for (int i = 0; i < coleccion.Count; i++)
            {
                serie.Serialize(flujo, (SMS)coleccion[i]);
            }
            flujo.Close();
        }

        public void AnadirSMS(SMS mensaje)
        {
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
        }

        public ArrayList CargarRegistro()
        {
            ArrayList coleccion = new ArrayList();
            SMS datos;

            if (File.Exists("Datos.dat"))
            {
                flujo = new FileStream("Datos.dat", FileMode.Open, FileAccess.Read);
                try
                {
                    while (true)
                    {
                        bool encontrado = false;
                        datos = (SMS)serie.Deserialize(flujo);

                        for (int i = 0; i < coleccion.Count; i++)
                        {
                            if ((int)coleccion[i] == datos.DevolverNumero)
                            {
                                encontrado = true;
                            }
                        }
                        if (!encontrado)
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
                }
            }
            else
            {
                MessageBox.Show("No existe ningún registro", "Atención", MessageBoxButtons.OK);
            }
            return coleccion;
        }

        public ArrayList CargarHistorial(Configuracion usuario, int numero)
        {
            ArrayList coleccion = new ArrayList();
            SMS datos;

            if (File.Exists("Datos.dat"))
            {
                flujo = new FileStream("Datos.dat", FileMode.Open, FileAccess.Read);
                try
                {
                    while (true)
                    {
                        datos = (SMS)serie.Deserialize(flujo);
                        if ((usuario.DevolverUsuario == datos.DevolverUsuario) && (usuario.DevolverContrasena == datos.DevolverContrasena) && (numero == datos.DevolverNumero))
                        {
                            coleccion.Add(datos);
                        }
                    }
                }
                catch (SerializationException) { }
                catch (EndOfStreamException) { }
                finally
                {
                    flujo.Close();
                }
            }
            else
            {
                MessageBox.Show("El Historial esta vacío", "Atención", MessageBoxButtons.OK);
            }

            return coleccion;
        }
    }
}
