using System;

namespace SMS_Collector
{
    [Serializable]
    public class Configuracion
    {
        string usuario;
        int contrasena;

        public Configuracion(string usuario2, int contrasena2)
        {
            usuario = usuario2;
            contrasena = contrasena2;
        }

        public string DevolverUsuario
        {
            get
            {
                return usuario;
            }
        }

        public int DevolverContrasena
        {
            get
            {
                return contrasena;
            }
        }

        public void AsignarUsuario(string usuario2)
        {
            usuario = usuario2;
        }

        public void AsignarContrasena(int contrasena2)
        {
            contrasena = contrasena2;
        }
    }
}
