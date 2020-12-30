﻿using System;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstWindow());
        }
    }
}