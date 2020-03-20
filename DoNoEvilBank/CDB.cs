using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace DoNoEvilBank
{
    //Handles DB operations
    class CDB
    {

        //Opens a connection to a SQL DB
        public Boolean OpenDB()
        {
            CDBConstants.objSqlCommand = new SqlCommand();
            Boolean blnResult;

            if(CDBConstants.objSQLConn  == null)
            {
                try
                {
                    CDBConstants.objSQLConn = new SqlConnection(CDBConstants.gstrConn);
                    CDBConstants.objSQLConn.Open();
                    blnResult = true;
                }
                catch (Exception exOpenConnError)
                {
                    MessageBox.Show("Error opening Database in OpenDB " +  exOpenConnError.ToString());
                    blnResult = false;
                }

            }
            else
            {
                if (CDBConstants.objSQLConn.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return blnResult;
        }

        //Close connection DB
        public void CloseDB()
        {
            try
            {
                CDBConstants.objSQLConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error attempting to close database: " + ex.ToString(), "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Get a data reader with a stored procedure
        public SqlDataReader GetSqlDataReaderBySP(String strP, ArrayList parameters)
        {
            if(!OpenDB())
            {
                MessageBox.Show("Unable to get DataReader, DB openining problem.");
                return null;
            }
            SqlCommand objSqlCommand = new SqlCommand(strP, CDBConstants.objSQLConn);
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            if(!(parameters == null))
            {
                foreach (SqlParameter param in parameters)
                {
                    objSqlCommand.Parameters.Add(param);
                }
                try
                {
                   return objSqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to get datareader: " + ex.ToString(), "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
            return null;
        }

        //Gets a DataAdapter with a Stored procedure
        public SqlDataAdapter GetDataAdapterBySP(String strSP, ArrayList parameters)
        {
            if (!OpenDB())
            {
                MessageBox.Show("Unable to get DataAdapter, DB openining problem.");
                return null;
            }

            SqlCommand objSQLCommand = new SqlCommand(strSP, CDBConstants.objSQLConn);
            SqlDataAdapter sqlDA;
            objSQLCommand.CommandType = CommandType.StoredProcedure;
            if (!(parameters ==  null))
            {
                foreach (SqlParameter param in parameters)
                {
                    objSQLCommand.Parameters.Add(param);
                }
            }
            try
            {
                sqlDA = new SqlDataAdapter(objSQLCommand);
                return sqlDA;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to get datareader: " + ex.ToString(), "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;
        }
        

        //Execues a SP
        public int ExecSP(string strSP, ArrayList parameters)
        {
            //Return -1 if failed
            //Else return number of rows affected
            
            if (!OpenDB())
            {
                MessageBox.Show("Unable to Executre SP, DB openining problem.");
                return -1;
            }

            SqlCommand objSQLCommand = new SqlCommand(strSP, CDBConstants.objSQLConn);
            objSQLCommand.CommandType = CommandType.StoredProcedure;

            try
            {
                if (!(parameters==null))
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        objSQLCommand.Parameters.Add(parameter);

                    }
                    return objSQLCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error excecuting SP: " + ex.ToString(), "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return -1;

        }

        
        //Used to return a value from a stored procedure 
        public string GetSingleValueFromSP(string strSP, ArrayList parameters)
        {
            SqlDataReader sqlDR = GetSqlDataReaderBySP(strSP, parameters);
            string strResult;
            if(!(sqlDR == null))//We have a DR
            {
                if (sqlDR.Read())
                {
                    strResult = sqlDR.GetValue(0).ToString();
                    sqlDR.Close();
                    return strResult;
                }
                else
                {
                    return "-1";
                }
            }
            return "-2";
        }


    }
}
