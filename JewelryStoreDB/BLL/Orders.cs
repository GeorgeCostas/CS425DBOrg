using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Orders
    {
        public void Insert(String sAccountId, String sObjectType, String sAmount, String sDescription)
        {
            String sSQL = "insert into Orders(O_SubmitDate, O_AccountId, O_ObjectType, O_Amount, O_Description, O_State, O_IsPaid) values (";
            sSQL += "'" + DateTime.Now.ToString() + "', ";
            sSQL += sAccountId + ", ";
            sSQL += "'" + sObjectType + "', ";
            sSQL += "'" + sAmount + "', ";
            sSQL += "'" + sDescription + "', ";
            sSQL += "'pending', ";
            sSQL += "0";
            sSQL += ")";
            new DAL.DatabaseAccess().Execute(sSQL);
        }

        public DataSet Select(String sSQL)
        {
            return new DAL.DatabaseAccess().Select(sSQL);
        }

        public void Update(String sSQL)
        {
            new DAL.DatabaseAccess().Execute(sSQL);
        }
    }
}
