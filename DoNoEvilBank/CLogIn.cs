using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoNoEvilBank
{
    static class CLogIn
    {
       
        //SP that checks the SQL database to see if the user login credentials are valid
        static public string LogIn(string username, string password)
        {

            string strResult; 
            ArrayList parameters = new ArrayList();
            parameters.Add(new SqlParameter("userName", username));
            parameters.Add(new SqlParameter("password", password));

            strResult = CDBConstants.myDB.GetSingleValueFromSP("sp_checkLogin", parameters);
            return strResult;

        }

        
    }
}
