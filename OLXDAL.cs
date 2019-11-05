using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using OLXRESALEMODELLIBRARY;

namespace OLXDALLIBRARY
{
    public class OLXDAL
    {
        SqlConnection con;
        SqlCommand cmdinsertuser;
        SqlCommand cmditem;
        SqlDataAdapter dauser;
        
        public OLXDAL()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["OLX"].ConnectionString);
            dauser = new SqlDataAdapter("Get_User_Details", con);
            dauser.SelectCommand.CommandType = CommandType.StoredProcedure;
            cmdinsertuser = new SqlCommand("Insert_User_detials", con);
            cmdinsertuser.CommandType = CommandType.StoredProcedure;
            cmdinsertuser.Parameters.Add("@fn", SqlDbType.VarChar, 50);
            cmdinsertuser.Parameters.Add("@ln", SqlDbType.VarChar, 50);
            cmdinsertuser.Parameters.Add("@age", SqlDbType.Int);
            cmdinsertuser.Parameters.Add("@gender", SqlDbType.VarChar,10);
            cmdinsertuser.Parameters.Add("@connumber", SqlDbType.VarChar, 10);
            cmdinsertuser.Parameters.Add("@userid", SqlDbType.VarChar, 15);
            cmdinsertuser.Parameters.Add("@pass", SqlDbType.VarChar, 15);
            cmdinsertuser.Parameters.Add("@email", SqlDbType.VarChar, 30);
            cmdinsertuser.Parameters.Add("@address", SqlDbType.VarChar, 30);
            cmditem = new SqlCommand("Insert_item", con);
            cmditem.CommandType = CommandType.StoredProcedure;
            cmditem.Parameters.Add("@Itemname", SqlDbType.VarChar, 50);
            cmditem.Parameters.Add("@Itemid", SqlDbType.VarChar, 50);
            cmditem.Parameters.Add("@Yearofusage", SqlDbType.Int);
            cmditem.Parameters.Add("@Category", SqlDbType.VarChar, 50);
            cmditem.Parameters.Add("Amount", SqlDbType.VarChar,50);
            cmditem.Parameters.Add("@Userid", SqlDbType.VarChar, 50);
            cmditem.Parameters.Add("@image", SqlDbType.VarBinary);


        }
        public bool Insert_User_details(OLXMODEL o)
        {
            bool bresult = false;
            cmdinsertuser.Parameters[0].Value = o.FirstName;
            cmdinsertuser.Parameters[1].Value = o.LastName;
            cmdinsertuser.Parameters[2].Value = o.Age;
            cmdinsertuser.Parameters[3].Value = o.Gender;
            cmdinsertuser.Parameters[4].Value = o.ContactNumber;
            cmdinsertuser.Parameters[5].Value = o.UserId;
            cmdinsertuser.Parameters[6].Value = o.Password;
            cmdinsertuser.Parameters[7].Value = o.Email;
            cmdinsertuser.Parameters[8].Value = o.Address;
            if (con.State == ConnectionState.Open)
                con.Close();
            else
                con.Open();
            int ires = cmdinsertuser.ExecuteNonQuery();
            if(ires==1)
                bresult= true;
            return bresult;

        }
        public List<OLXMODEL> Get_details()
        {
            List<OLXMODEL> ol = new List<OLXMODEL>();
            DataSet dsuser = new DataSet();
            OLXMODEL om;
            dauser.Fill(dsuser);
            foreach(DataRow dr in dsuser.Tables[0].Rows)
            {
                om= new OLXMODEL();
                om.FirstName = dr[0].ToString();
                om.LastName = dr[1].ToString();
                om.Age=Convert.ToInt32(dr[2].ToString());
                om.ContactNumber = dr[3].ToString();
                om.Gender = dr[4].ToString();
                om.UserId = dr[5].ToString();
                om.Password = dr[6].ToString();
                om.Email = dr[7].ToString();
                om.Address = dr[8].ToString();
                ol.Add(om);
            }
            return ol;
        }
        public bool insertitem(OLXMODEL m)
        {
            bool res = false;
            cmditem.Parameters[0].Value = m.Itemname;
            cmditem.Parameters[1].Value = m.Itemid;
            cmditem.Parameters[2].Value = m.Yearofusage;
            cmditem.Parameters[3].Value = m.Catname;
            cmditem.Parameters[4].Value = m.Amount;
            cmditem.Parameters[5].Value = m.Uid;
            cmditem.Parameters[6].Value = m.Image;
            con.Open();
            int result = cmditem.ExecuteNonQuery();
            if(result==1)
            {
                res = true;
            }

            return res;
        }
    }
}