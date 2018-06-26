using System;
using System.Windows.Forms;

namespace Receipts
{
    static class Program
    {
        /// <summary>
        /// Main point of application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
