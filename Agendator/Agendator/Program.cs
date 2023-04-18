using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Agendator

{
    static class Program
    {
        /// <summary> puse esto para que figure como que hice algo
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }

    }
}