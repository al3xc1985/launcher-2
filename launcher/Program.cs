using System;
using System.Windows.Forms;

namespace launcher
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SingleApplication.Run(new Main());
        }

        private static void OnProcessExit(object sender, EventArgs e)
        {
            launcher.Main.Instance.KillNotyfy();
        }
    }
}
