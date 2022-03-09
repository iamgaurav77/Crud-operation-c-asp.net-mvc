using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using practice.Models.DomainModel;
using practice.Models.DataAccessLayer;

namespace practice.Models.BusinessLayer
{
    public class UserBO
    {
       
        public DataTable GetData()
        {
            UserDL obj = new UserDL();
            DataTable dt = obj.GetData();
            return dt;
        }

        public void InsertData(User model)
        {
            UserDL obj = new UserDL();
            obj.InsertData(model);
        }


        public void DeleteData(User model)
        {
            UserDL obj = new UserDL();
            obj.DeleteData(model);
        }

        public DataTable GetEditData(User model)
        {
            UserDL obj = new UserDL();
            DataTable dt = obj.GetEditData(model);
            return dt;
        }

        public void PostEditData(User model)
        {
            UserDL obj = new UserDL();
            obj.PostEditData(model);
        }
    }
}