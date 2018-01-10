﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;

namespace Encryptior
{   
    static class Program
    {
        public static string WalletPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/Encryptior Wallet/";
        public static string PrivateKey;
        public static string ActiveAddress;
        public static ApiWorker apiWorker = new ApiWorker();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (CheckInternetConnection())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.ThreadException += new ThreadExceptionEventHandler(ExceptionHandler);
                Application.Run(new EncryptiorMainPage());
            }
            else
            {
                MessageBox.Show("You need an active internet connection to use this application.", "Application problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void ExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
            var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);

            var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());

            dialog.Text = "An error has occured";
            dialogType.GetProperty("Details").SetValue(dialog, e.Exception.Message + "\n" + e.Exception.StackTrace, null);
            dialogType.GetProperty("Message").SetValue(dialog, "Unhandled error had happened. Click details for details", null);
            var result = dialog.ShowDialog();
        }

        public static bool CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
