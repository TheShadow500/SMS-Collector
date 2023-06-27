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
        const string archivo_configuracion = "Config.cfg";
        const string archivo_numeros = "Numeros.dat";
        const string archivo_intentos = "Intentos.dat";
        const string archivo_datos = "Datos.dat";

        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;
        FileStream flujo2;
        Configuracion datos;

        public bool ComprobarArchivo(int opcion)
        {
            switch(opcion)
            {
                case 1:
                    if(File.Exists(archivo_configuracion))
                    {
                        return true;
                    }
                    break;
                case 2:
                    if(File.Exists(archivo_numeros))
                    {
                        return true;
                    }
                    break;
                case 3:
                    if(File.Exists(archivo_intentos))
                    {
                        return true;
                    }
                    break;
                case 4:
                    if(File.Exists(archivo_datos))
                    {
                        return true;
                    }
                    break;
                default:
                    return false;
            }

            return false;
        }

        public Configuracion CargarUsuario()
        {
            if (ComprobarArchivo(1))
            {
                flujo = new FileStream("Config.cfg", FileMode.Open, FileAccess.Read);
                datos = (Configuracion)serie.Deserialize(flujo);
                flujo.Close();
            }
            else
            {
                datos = new Configuracion("Admin", 12345);
                MessageBox.Show("No existe el archivo Config.cfg", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("No hay ningún usuario creado.\nSe han aplicado los valores por defecto:\n\nUsuario: Admin\nContraseña: 12345", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Para mayor seguridad, asegúrese de configurar el nombre de usuario y la contraseña desde Archivo -> Preferencias", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show("Cargado el perfil: " + datos.DevolverUsuario, "Información", MessageBoxButtons.OK);

            return datos;
        }

        public void ModificarContrasena(Configuracion datos)
        {
            flujo = new FileStream(archivo_configuracion, FileMode.Create, FileAccess.Write);
            serie.Serialize(flujo, datos);
            flujo.Close();

            MessageBox.Show("Modificado con éxito.\nSe reiniciará el programa para que los cambios tengan efecto", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Restart();
        }

        public void AnadirContacto(Persona persona)
        {
            if(ComprobarArchivo(2))
            {
                flujo = new FileStream(archivo_numeros, FileMode.Append, FileAccess.Write);
            }
            else
            {
                flujo = new FileStream(archivo_numeros, FileMode.Create, FileAccess.Write);
            }

            serie.Serialize(flujo, persona);
            flujo.Close();
            MessageBox.Show("Perfil guardado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public ArrayList ConsultarIntentos()
        {
            ArrayList intentos = new ArrayList();

            if (ComprobarArchivo(3))
            {
                flujo = new FileStream(archivo_intentos, FileMode.Open, FileAccess.Read);

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
                MessageBox.Show("No hay ningún registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return intentos;
        }

        public void CrearIntento(Configuracion usuario, string contrasena)
        {
            string error;

            error = Convert.ToString("Usuario: " + usuario.DevolverUsuario + " - " + DateTime.Now + " - Contraseña: " + contrasena);

            if (ComprobarArchivo(3))
            {
                flujo = new FileStream(archivo_intentos, FileMode.Append, FileAccess.Write);
            }
            else
            {
                flujo = new FileStream(archivo_intentos, FileMode.Create, FileAccess.Write);
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
                        MessageBox.Show("Copia de Seguridad realizada con éxito", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Copia de Seguridad restaurada con éxito", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (archivoorigen.CompareTo("Datos.dat") == 0)
                {
                    MessageBox.Show("No existe ningun fichero de datos", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No existe ninguna Copia de Seguridad para restaurar", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void OrdenarRegistro()
        {
            ArrayList coleccion = new ArrayList();
            SMS datos;
            SMS datos2;
            int sw;

            if (ComprobarArchivo(4))
            {
                flujo = new FileStream(archivo_datos, FileMode.Open, FileAccess.Read);
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
                    MessageBox.Show("Registro ordenado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No existe ningún registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CrearArchivo(ArrayList coleccion)
        {
            flujo = new FileStream(archivo_datos, FileMode.Create, FileAccess.Write);
            for (int i = 0; i < coleccion.Count; i++)
            {
                serie.Serialize(flujo, (SMS)coleccion[i]);
            }
            flujo.Close();
        }

        public void AnadirSMS(SMS mensaje)
        {
            if (ComprobarArchivo(4))
            {
                flujo = new FileStream(archivo_datos, FileMode.Append, FileAccess.Write);
            }
            else
            {
                flujo = new FileStream(archivo_datos, FileMode.Create, FileAccess.Write);
            }
            serie.Serialize(flujo, mensaje);
            flujo.Close();
        }

        public ArrayList CargarRegistroCompleto()
        {
            ArrayList coleccion = new ArrayList();

            if (ComprobarArchivo(4))
            {
                flujo = new FileStream(archivo_datos, FileMode.Open, FileAccess.Read);
                try
                {
                    while (true)
                    {
                        coleccion.Add((SMS)serie.Deserialize(flujo));
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
                MessageBox.Show("No existe ningún registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return coleccion;
        }

        public ArrayList CargarRegistro()
        {
            ArrayList coleccion = new ArrayList();
            SMS datos;

            if (ComprobarArchivo(4))
            {
                flujo = new FileStream(archivo_datos, FileMode.Open, FileAccess.Read);
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
                MessageBox.Show("No existe ningún registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return coleccion;
        }

        public ArrayList CargarHistorial(Configuracion usuario, int numero)
        {
            ArrayList coleccion = new ArrayList();
            SMS datos;

            if (ComprobarArchivo(4))
            {
                flujo = new FileStream(archivo_datos, FileMode.Open, FileAccess.Read);
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
                MessageBox.Show("El Historial esta vacío", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return coleccion;
        }

        public void QuienEs(int numero, fr_Visualizar formulario)
        {
            bool encontrado = false;

            if (ComprobarArchivo(2))
            {
                FileStream flujo = new FileStream(archivo_numeros, FileMode.Open, FileAccess.Read);
                try
                {
                    while (true)
                    {
                        Persona aux = (Persona)serie.Deserialize(flujo);
                        if (aux.DevolverMovil == numero)
                        {
                            encontrado = true;
                            fr_QuienEs quienes = new fr_QuienEs(aux.DevolverNombre, aux.DevolverApellidos, aux.DevolverEmail, aux.DevolverMovil, formulario);
                            quienes.StartPosition = FormStartPosition.CenterScreen;
                            quienes.Show();
                            formulario.Hide();
                            break;
                        }
                        else
                        {
                            encontrado = false;
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
                encontrado = false;
            }
            if (!encontrado)
            {
                DialogResult seleccion = MessageBox.Show("No existe información sobre el número " + numero + ". ¿Desea añadirla?", "Atención", MessageBoxButtons.YesNo);
                if (seleccion == DialogResult.Yes)
                {
                    fr_AñadirContacto añadir = new fr_AñadirContacto(Convert.ToString(numero), formulario);
                    añadir.StartPosition = FormStartPosition.CenterScreen;
                    añadir.Show();
                    formulario.Hide();
                }
            }
        }

        public void QuienEsModificar(Persona aux)
        {
            if(ComprobarArchivo(2))
            {
                ArrayList personas = new ArrayList();
                flujo = new FileStream(archivo_numeros, FileMode.Open, FileAccess.Read);

                try
                {
                    while (true)
                    {
                        Persona aux2 = (Persona)serie.Deserialize(flujo);
                        if (aux.DevolverMovil == aux2.DevolverMovil)
                        {
                            personas.Add(aux);
                        }
                        else
                        {
                            personas.Add(aux2);
                        }
                    }
                }
                catch (SerializationException) { }
                catch (EndOfStreamException) { }
                finally
                {
                    flujo.Close();
                    flujo = new FileStream(archivo_numeros, FileMode.Open, FileAccess.Write);
                    for (int i = 0; i < personas.Count; i++)
                    {
                        serie.Serialize(flujo, personas[i]);
                    }
                    flujo.Close();
                    MessageBox.Show("Información de contacto modificada con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se pueden guardar los datos", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
