using System;

namespace SMS_Collector
{
    [Serializable]
    class Configuracion
    {
        string usuario;
        int contraseņa;

        public Configuracion(string usuario2, int contraseņa2)
        {
            usuario = usuario2;
            contraseņa = contraseņa2;
        }

        public string DevolverUsuario
        {
            get
            {
                return usuario;
            }
        }

        public int DevolverContraseņa
        {
            get
            {
                return contraseņa;
            }
        }
    }
}
