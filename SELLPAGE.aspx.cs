using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using OLXRESALEBLLIBRARY;
using OLXRESALEMODELLIBRARY;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace OLXRESALEFE
{
    
    public partial class SELLPAGE : System.Web.UI.Page
    {
        OLXBL b = new OLXBL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }
       
        protected void btnupload_Click(object sender, EventArgs e)
        {
            
                Stream stream = fuimg.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(stream);
                byte[] b = br.ReadBytes((int)stream.Length);
                string s = Convert.ToBase64String(b, 0, b.Length);
                imgprw.ImageUrl = "data:image/png;base64," + s;
                imgprw.Visible = true;
   

        }
        protected void btnpostnow_Click(object sender, EventArgs e)
        {
            HttpPostedFile postedfile = fuimg.PostedFile;
            string filename = Path.GetFileName(postedfile.FileName);
            string extension = Path.GetExtension(filename);
            if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png" || extension.ToLower() == ".gif")
            {
                Stream stream = postedfile.InputStream;
                BinaryReader binaryreader = new BinaryReader(stream);
                byte[] bytes = binaryreader.ReadBytes((int)(stream.Length));
                OLXMODEL m = new OLXMODEL();
                m.Itemname = txtitemname.Text;
                m.Itemid = txtitemid.Text;
                m.Yearofusage = int.Parse(txtyearofusage.Text);
                m.Catname = ddcategory.SelectedItem.Text;
                m.Amount = txtamount.Text;
                m.Uid = txtuid.Text;
                m.Image = bytes;
                if (b.Insertitem(m))
                    lblmessage.Text = "Sucess";
            }



        }

       

        //protected void btnshow_Click(object sender, EventArgs e)
        //{
        //    string fname = Path.GetFileName(fuimg.FileName);
        //    fuimg.SaveAs(Server.MapPath(("~/Image/")) + fname);
        //    string Filename = "Image/" + fname;
        //    imgprw.ImageUrl = Filename;
        //}
    }
}