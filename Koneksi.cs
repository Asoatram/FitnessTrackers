using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bebas
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString ="Server = tcp:databasesqlfitnesstrackers.database.windows.net, 1433; Database = database_fitnesstracker; Persist Security Info=False;User ID = Asoatram; Password=daffa2!34;" +
         "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
            return conn;
        }
    }
}
