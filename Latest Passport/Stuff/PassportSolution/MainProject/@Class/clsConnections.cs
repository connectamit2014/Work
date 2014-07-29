using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PassportSystem
{
    public class ClsConnections
    {
        //database connection
        public static OleDbConnection CN = new OleDbConnection();
        public void setConnection(string sLocation, string sDBName, string sPassword)
        {
            CN.Close();
            string sProvider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sLocation + sDBName + ";Persist Security Info=False;Jet OLEDB:Database Password=" + sPassword;
            CN.ConnectionString = sProvider;
            CN.Open();
        }

        public bool IsOpened { set; get; }
    }

    public static class Users
    {
        public static string User { set; get; }
    
    
    }
}
