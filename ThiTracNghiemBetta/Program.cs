using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
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
            ThiTracNghiemBetta.Properties.Settings.Default["TN_CSDLPTConnectionString"] = "Data Source=DESKTOP-HLI8HSQ;Initial Catalog=TN_CSDLPT;Persist Security Info=True;User ID=sa;Password=12";
            Application.Run(new frmLogin());
        }
    }
}
