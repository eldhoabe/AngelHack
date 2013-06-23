using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloudDo1Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtbxMail.Text != null && txtbxMail.Text != "")
            {
                Myservice.Service1Client myservice = new Myservice.Service1Client();
                int Status=myservice.Getuserbymail(txtbxMail.Text);

                if (Status > 0)
                {
                    Session.Add("Userid", Status);
                    Response.Redirect("TaskPage.aspx");
                }
                else
                {
                    Lblmsg.Text = "please check Your mail id";
                }
            }
        }
    }
}