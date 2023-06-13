using System;

namespace SMS_Collector
{
    [Serializable]
    class Persona
    {
        string nombre;
        string apellidos;
        string email;
        int movil;

        public Persona(string nombre2, string apellidos2, string email2, int movil2)
        {
            nombre = nombre2;
            apellidos = apellidos2;
            email = email2;
            movil = movil2;
        }

        public string DevolverNombre
        {
            get
            {
                return nombre;
            }
        }

        public string DevolverApellidos
        {
            get
            {
                return apellidos;
            }
        }

        public string DevolverEmail
        {
            get
            {
                return email;
            }
        }

        public int DevolverMovil
        {
            get
            {
                return movil;
            }
        }
    }
}
