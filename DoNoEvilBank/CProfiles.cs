using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNoEvilBank
{
    //Holds database operations performed by profiles form
    static class CProfiles
    {

        //Gets a data reader that holds the profile information
        static public SqlDataReader GetProfileByID(string ProfileID)
        {
            SqlDataReader objDR;
            ArrayList parameters = new ArrayList();
            parameters.Add(new SqlParameter("profileID", ProfileID));

            objDR = CDBConstants.myDB.GetSqlDataReaderBySP("sp_getProfileByID", parameters);
            return objDR;
        }

        //Creates a profile, return 1 if succesfull
        static public int CreateProfile(ArrayList parameters)
        {
            int intResult;

            intResult = CDBConstants.myDB.ExecSP("sp_createProfile", parameters);

            return intResult;
           
        }

        //Update profile, return 1 if succesfull 
        static public int UpdateProfile(ArrayList parameters)
        {
            int intResult;

            intResult = CDBConstants.myDB.ExecSP("sp_updateProfileByID", parameters);

            return intResult;

        }
        //Checks to see if the profile exists in the DB using the ID
        static public string CheckProfileExists(int intProfileID)
        {

            string strResult;
            ArrayList parameters = new ArrayList();
            parameters.Add(new SqlParameter("profileID", intProfileID));

            strResult = CDBConstants.myDB.GetSingleValueFromSP("sp_checkProfileExistsByID", parameters);
            return strResult;

        }

        //Return a data reader with account information using profileID
        static public SqlDataReader GetAccountsByID(string ProfileID)
        {
            SqlDataReader objDR;
            ArrayList parameters = new ArrayList();
            parameters.Add(new SqlParameter("profileID", ProfileID));

            objDR = CDBConstants.myDB.GetSqlDataReaderBySP("sp_getAccountsByProfileID", parameters);
            return objDR;
        }


    }


}
