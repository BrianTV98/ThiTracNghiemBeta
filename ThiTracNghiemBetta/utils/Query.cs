using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiemBetta.utils
{
    static class Query
    {
        public static int QueryBase(string strLenh)
        {
                SqlDataReader myreader;
                SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
                sqlcmd.CommandType = CommandType.Text;
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                try
                {
                    myreader = sqlcmd.ExecuteReader();
                    Program.conn.Close();
                    return 0;


                }
                catch (SqlException ex)
                {
                    Program.conn.Close();
                    //MessageBox.Show(ex.Message);
                    return 1;
                }
            
        }
    }
}
