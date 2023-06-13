using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SMS_Collector
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fr_MenuPrincipal());
        }
    }
}