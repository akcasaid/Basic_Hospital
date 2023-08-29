using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    internal static class Program
    {
        // -------------------------- (Said Akça ) -----------------------------------------

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()h
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmGirisler());
        }
    }
}
