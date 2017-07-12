using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace AutoBlockConfigs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] all = Process.GetProcessesByName("AutoBlockConfigs");
            if (all.Length == 1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else MessageBox.Show("Só é possível abrir uma instancia por vez", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
