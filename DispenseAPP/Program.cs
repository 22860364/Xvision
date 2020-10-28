using System;
using System.Threading;
using System.Windows.Forms;

namespace DispenseAPP
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Mutex mutex = new Mutex(true, System.Diagnostics.Process.GetCurrentProcess().ProcessName, out bool isRuningApp);
            //if ( !isRuningApp)
            //{
            //    Environment.Exit(1);
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrimary());
        }
    }
}
