using DispenseAPP.CustomControl;
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
            bool isRuningApp = false;
            Mutex mutex = new Mutex(true, System.Diagnostics.Process.GetCurrentProcess().ProcessName, out isRuningApp);
            if( !isRuningApp)
            {
                Environment.Exit(1);
            }
            string filePath = "";
            if(args != null && args.Length >0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    filePath += " " + args[i];
                }
                filePath.Trim();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrimary(filePath));
        }
    }
}
