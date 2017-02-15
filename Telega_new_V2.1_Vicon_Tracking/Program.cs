using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Telega_new_V2._1_Vicon_Tracking
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Form1());
            }
            catch
            {
                MessageBox.Show("Application crashed on \"Application.Run()\". Probably missing required libraries.", "Error");
            }
        }
    }
}
