using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoNoEvilBank
{
    //Stores database and connection string
    static class CDBConstants
    {
        //Necessary objects for SQL Connection
        public static SqlConnection objSQLConn;
        public static SqlCommand  objSqlCommand;
        public static string gstrConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\darie\source\repos\DoNoEvilBank\DNEBank.mdf;Integrated Security=True";
        public static CDB myDB;
    }
}
