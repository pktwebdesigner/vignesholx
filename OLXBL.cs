using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OLXDALLIBRARY;
using OLXRESALEMODELLIBRARY;


namespace OLXRESALEBLLIBRARY
{
    public class OLXBL
    {
        List<OLXMODEL> om = new List<OLXMODEL>();
        OLXDAL dal;
        
        public OLXBL()
        {
            dal = new OLXDAL();
            om = dal.Get_details();
        }
        public bool InsertDetails(OLXMODEL o)
        {
            bool bresult = false;
            Predicate<OLXMODEL> Checkucnum = ucn => ucn.ContactNumber == o.ContactNumber;
            Predicate<OLXMODEL> Checkpass = up => up.Password == o.Password;
            Predicate<OLXMODEL> Checkmail = um => um.Email == o.Email;
            if (om.Find(Checkucnum) == null || om.Find(Checkpass) ==null || om.Find(Checkmail) == null)
            {
                if (dal.Insert_User_details(o))
                    bresult = true;
            }
            return bresult;
        }
        public bool GETUSERDETAILS(OLXMODEL m)
        {
            bool bresult = false;
            Predicate<OLXMODEL> Checkuserid = uid => uid.UserId == m.UserId;
            Predicate<OLXMODEL> CheckuserPass = up => up.Password == m.Password;
            if (om.Find(Checkuserid) != null && om.Find(CheckuserPass) != null)
                bresult = true;
            return bresult;
        }
        public bool Insertitem(OLXMODEL m)
        {
            bool res=false;
            if(dal.insertitem(m))
            {
                res = true;
            }
            return res;
        }

    }
}