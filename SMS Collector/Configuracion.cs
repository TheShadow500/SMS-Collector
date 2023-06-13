using System;
using System.Windows.Forms;

namespace SMS_Collector
{
    [Serializable]
    class Configuracion
    {
        string usuario;
        int contraseña;

        public Configuracion(string usuario2, int contraseña2)
        {
            usuario = usuario2;
            contraseña = contraseña2;
        }

        public string DevolverUsuario
        {
            get
            {
                return usuario;
            }
        }

        public int DevolverContraseña
        {
            get
            {
                return contraseña;
            }
        }
    }
}
