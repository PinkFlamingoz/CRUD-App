using CRUD_App.Presenter;
using CRUD_App.View;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace CRUD_App
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
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["CRUD_App.Properties.Settings.SqlConnection"].ConnectionString;
            MainInterface view = new MainView();
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
