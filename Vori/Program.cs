﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vori
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        public static string UserName = "Создатель";

        //public static Form NameF;
        public static Form VoriF;
        public static Form NeiroNetF;

        public static string RootText = "Активированы root права!";
        public static bool RootOn = false;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Starting StartingF = new Starting();

            DateTime end = DateTime.Now + TimeSpan.FromSeconds(5);

            StartingF.Show();

            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }

            StartingF.Close();
            StartingF.Dispose();

            Application.Run(new NameForm());
        }
    }
}
