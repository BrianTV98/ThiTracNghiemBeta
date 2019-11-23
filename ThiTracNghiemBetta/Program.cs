using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using ThiTracNghiemBetta.connection;
using ThiTracNghiemBetta.form;

namespace ThiTracNghiemBetta
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

            BonusSkins.Register();
            // Hien ServerConnection
            // AppConnection.type = AppServerType.Server1;

            ThiTracNghiemBetta.Properties.Settings.Default["TN_CSDLPTConnectionString"] = AppConnection.getConnection().masterConnection;
            Application.Run(new frmLogin());
        }
    }
}
