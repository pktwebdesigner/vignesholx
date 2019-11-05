using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OLXRESALEBLLIBRARY;
using OLXRESALEMODELLIBRARY;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Xml.Linq;

namespace OLXRESALEFE
{
    public partial class LOGINPAGE : System.Web.UI.Page
    {
        OLXBL b = new OLXBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnlogin_Click1(object sender, EventArgs e)
        {
            OLXMODEL od = new OLXMODEL();
            od.UserId = txtuid.Text;
            od.Password = txtpass.Text;
            if (b.GETUSERDETAILS(od))
                lblMessage.Text = "Login Successfully";
            else
                lblMessage.Text = "Invalid Login Details";
        }

       

        

    }
}