﻿using System;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;

namespace AndroidSideloader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
        static void Main()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            form = new MainForm();
            Application.Run(form);
            //form.Show();
        }
        public static MainForm form;
        //handle crashes
        static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            File.WriteAllText(Sideloader.CrashLogPath, $"Message: {e.Message}\nData: {e.Data}\nSource: {e.Source}\nTargetSite: {e.TargetSite}");
        }
    }
    static class Global
    {
        private static string _globalVar = "";

        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
    }
}
