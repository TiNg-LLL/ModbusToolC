using System;
using System.IO;
using System.Windows.Forms;
using ZeroFunc;

namespace FirstWindow
{
    internal static class ProgramMain
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Dayend z = new Dayend();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstWindow());
        }
    }
}