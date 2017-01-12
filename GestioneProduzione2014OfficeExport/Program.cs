using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestioneProduzione2014OfficeExport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmOffertaExcel());
        }
    }
}