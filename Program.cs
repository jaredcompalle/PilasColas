using System;
using System.Windows.Forms;

namespace PilasColas
{
    /// <summary>
    /// Punto de entrada de la aplicación.
    /// Autor: Rosembert Jared Ortiz Reyes (I25050406) - TECNM
    /// </summary>
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
