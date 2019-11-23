using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum AppServerType
{
    Server0 = 0,
    Server1 = 1
}
namespace ThiTracNghiemBetta.connection
{
    class AppConnection {

        public static AppServerType type = AppServerType.Server0 ;
        private static  ConnectionModel appConnection0;
        private static  ConnectionModel appConnection1;

        public static ConnectionModel getConnection ()
        {
           if (type == AppServerType.Server0)
            {
                if (appConnection0 == null)
                {
                    appConnection0 = new ConnectionModel();
                    appConnection0.masterConnection = "Data Source=DESKTOP-HIEU\\HIEU1;Initial Catalog=TN_CSDLPT;User ID=sa;Password=123";
                }
                return appConnection0;
            } else
            {
                if (appConnection1 == null)
                {
                    appConnection1 = new ConnectionModel();
                    appConnection1.masterConnection = "Data Source=DESKTOP-HLI8HSQ;Initial Catalog=TN_CSDLPT;Persist Security Info=True;User ID=sa;Password=12";
                }
                return appConnection1;
            }
           
        }

    }
}
