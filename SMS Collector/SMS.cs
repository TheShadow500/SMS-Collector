using System;

namespace SMS_Collector
{
    [Serializable]
    class SMS
    {
        string dia;
        string mes;
        string a�o;
        string hora;
        string minuto;
        string mensaje;
        int numero;
        string usuario;
        int contrase�a;

        public SMS(string dia2, string mes2, string a�o2, string hora2, string minuto2, string mensaje2, int numero2, string usuario2, int contrase�a2)
        {
            dia = dia2;
            mes = mes2;
            a�o = a�o2;
            hora = hora2;
            minuto = minuto2;
            mensaje = mensaje2;
            numero = numero2;
            usuario = usuario2;
            contrase�a = contrase�a2;
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

        public string DevolverA�o
        {
            get
            {
                return a�o;
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

        public int DevolverContrase�a
        {
            get
            {
                return contrase�a;
            }
        }
    }
}
