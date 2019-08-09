using System;
using System.Windows.Forms;
namespace ClinicCat
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
            DataAccessLayer.ConnectionSettings.cn = new System.Data.SqlClient.SqlConnection();
            DataAccessLayer.ConnectionSettings.cn.ConnectionString = DataAccessLayer.ConnectionSettings.connection;
            DataAccessLayer.ConnectionSettings.cn.Open();
            Application.Run(new frmHOME());
        }
    }
}
