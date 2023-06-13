using System;

namespace SMS_Collector
{
    [Serializable]
    class SMS
    {
        string dia;
        string mes;
        string año;
        string hora;
        string minuto;
        string mensaje;
        int numero;
        string usuario;
        int contraseña;

        public SMS(string dia2, string mes2, string año2, string hora2, string minuto2, string mensaje2, int numero2, string usuario2, int contraseña2)
        {
            dia = dia2;
            mes = mes2;
            año = año2;
            hora = hora2;
            minuto = minuto2;
            mensaje = mensaje2;
            numero = numero2;
            usuario = usuario2;
            contraseña = contraseña2;
        }

        public string DevolverDia
        {
            get
            {
                return dia;
            }
        }

        public string DevolverMes
        {
            get
            {
                return mes;
            }
        }

        public string DevolverAño
        {
            get
            {
                return año;
            }
        }

        public string DevolverHora
        {
            get
            {
                return hora;
            }
        }

        public string DevolverMinuto
        {
            get
            {
                return minuto;
            }
        }

        public string DevolverMensaje
        {
            get
            {
                return mensaje;
            }
        }

        public int DevolverNumero
        {
            get
            {
                return numero;
            }
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
