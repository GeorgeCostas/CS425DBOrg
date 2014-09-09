using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class ObjectType
    {
        public DataSet Select(String sSQL)
        {
            return new DAL.DatabaseAccess().Select(sSQL);
        }
    }
}
