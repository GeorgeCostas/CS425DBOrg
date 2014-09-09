using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Add DLL
using System.Data;
using System.Data.SqlClient;    //SQL
using System.Data.OleDb;        //ACCESS
using System.Configuration;

namespace DAL
{
    public class DatabaseAccess
    {
        #region Define Variables
        public OleDbConnection conn;
        public OleDbCommand cmd;
        public DataView dv;
        public OleDbDataAdapter sda;
        public DataSet ds;
        #endregion

        #region Constructors
        public DatabaseAccess()
        {

        }
        #endregion

        #region Select
        /// <summary>
        /// Select
        /// </summary>
        /// <param name="sSQL">SQL</param>
        /// <returns>Return selected rows</returns>
        public DataSet Select(string sSQL)
        {
            if (conn == null)
            {
                conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLLocalSqlServer"].ConnectionString);
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            if (cmd == null)
            {
                cmd = new OleDbCommand();
            }

            cmd.CommandText = sSQL;
            cmd.Connection = conn;
            sda = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds);

            conn.Close();
            conn.Dispose();

            return ds;
        }
        #endregion

        #region Execute
        /// <summary>
        /// Execute
        /// </summary>
        /// <param name="sSQL">SQL</param>
        /// <returns>Return number of effected rows</returns>
        public int Execute(string sSQL)
        {
            if (conn == null)
            {
                conn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SQLLocalSqlServer"].ConnectionString);
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            if (cmd == null)
            {
                cmd = new OleDbCommand();
            }

            cmd.CommandText = sSQL;
            cmd.Connection = conn;
            int iEffectedRows = cmd.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();

            return iEffectedRows;
        }
        #endregion
    }
}
