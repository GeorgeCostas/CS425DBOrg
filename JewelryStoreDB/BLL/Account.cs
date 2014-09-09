using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Account
    {
        public void Insert(String sEmail, String sName, String sPassword, String sDescription, String sAddress, String sPhone)
        {
            String sSQL = "insert into Account(A_Email, A_Name, A_Password, A_Description, A_Address, A_PhoneNumber) values (";
            sSQL += "'" + sEmail + "', ";
            sSQL += "'" + sName + "', ";
            sSQL += "'" + sPassword + "', ";
            sSQL += "'" + sDescription + "', ";
            sSQL += "'" + sAddress + "', ";
            sSQL += "'" + sPhone + "', ";
            sSQL += ")";
            new DAL.DatabaseAccess().Execute(sSQL);
        }

        public bool IsExist(String sEmail, String sPassword)
        {
            String sSQL = "select * from Account where A_Email='" + sEmail + "' and A_Password='" + sPassword + "'";
            DataSet ds = new DAL.DatabaseAccess().Select(sSQL);
            if (ds.Tables[0].Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
