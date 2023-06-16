using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SMS_Collector
{
    class MetodosArchivos
    {
        BinaryFormatter serie = new BinaryFormatter();
        FileStream flujo;

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
    }
}
