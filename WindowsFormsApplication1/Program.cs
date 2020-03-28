using System;
using System.Windows.Forms;

namespace System_Forush
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
            Login l = new Login();
            if (l.ShowDialog() == DialogResult.OK)
                Application.Run(new MainForm());
            else
                Application.Exit();
        }
    }
}
