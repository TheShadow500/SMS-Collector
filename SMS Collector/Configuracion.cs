using System;
using System.Windows.Forms;

namespace SMS_Collector
{
    [Serializable]
    class Configuracion
    {
        string usuario;
        int contrase�a;

        public Configuracion(string usuario2, int contrase�a2)
        {
            usuario = usuario2;
            contrase�a = contrase�a2;
        }

        public string DevolverUsuario
        {
            get
            {
                return usuario;
            }
        }

        public int DevolverContrase�a
        {
            get
            {
                return contrase�a;
            }
        }
    }
}
