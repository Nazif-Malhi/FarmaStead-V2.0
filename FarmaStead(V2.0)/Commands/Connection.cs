using System;
using System.Data.SqlClient;
using System.IO;

namespace FarmaStead_V2._0_.Commands
{
    public class Connection
    {
     
        private static string path;
        private static string connectionString()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FarmaStead_db_conc";
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else
            {
                return "";
            }
        }
       
        public static SqlConnection con = new SqlConnection(connectionString());
        public bool IsConnection
        {
            get
            {
                if (con.State == System.Data.ConnectionState.Closed) 
                    con.Open();
                    return true;
            }
        }

      
    }
}
