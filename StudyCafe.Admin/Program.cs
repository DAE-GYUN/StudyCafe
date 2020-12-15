using DevExpress.Skins;
using DevExpress.UserSkins;
using EFLibrary;
using StudyCafe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudyCafe.Admin
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

            DbContextCreator.Context = () => new KoreanStudyCafeEntities();

            Application.Run(new MainForm());
        }
    }
}