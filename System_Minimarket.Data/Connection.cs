using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Minimarket.Data
{
    public class Connection
    {
        private string Database;
        private string Server;
        private string User;
        private string Key;
        private bool Security;
        private static Connection Con = null;

        private Connection()
        {
            this.Database = "BD_MINIMARKET";
            this.Server = "sayaf";
            this.User = "systems";
            this.Key = "Sayyaf45614";
            this.Security = false;
        }

        public SqlConnection CreateConection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = "Server=" + this.Server + "; Database=" + this.Database + ";";
                if (Security)
                {
                    sqlConnection.ConnectionString = sqlConnection.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    sqlConnection.ConnectionString = sqlConnection.ConnectionString + "User Id=" + this.User + "; Password=" + this.Key;
                }
            }
            catch (Exception ex)
            {
                sqlConnection = null;
                throw ex;
            }
            return sqlConnection;
        }

        public static Connection getInstance()
        {
            if (Con == null)
            {
                Con = new Connection();
            }
            return Con;
        }
    }
}
