using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OLXRESALEBLLIBRARY;
using OLXRESALEMODELLIBRARY;

namespace OLXRESALEFE
{
    public partial class LoginPage : System.Web.UI.Page
    {
        OLXBL b = new OLXBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            OLXMODEL m = new OLXMODEL();
            m.FirstName = txtfn.Text;
            m.LastName = txtln.Text;
            m.Age = Convert.ToInt32(txtage.Text);
            m.Gender = ddgen.SelectedValue;
            m.ContactNumber = txtcn.Text;
            m.UserId = txtUid.Text;
            m.Password = txtpass.Text;
            m.Email = txtmail.Text;
            m.Address = txtadd.Text;
            if (b.InsertDetails(m))
                lblerror.Text = "Successfull";
            else
                lblerror.Text = "Unsucessfull";

        }
    }
}