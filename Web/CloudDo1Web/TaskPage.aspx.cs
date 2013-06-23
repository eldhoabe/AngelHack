using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloudDo1Web
{
    public partial class TaskPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadForUser();
            //CHK();
        }

        public  void LoadForUser()
        {

            int Id =Convert.ToInt32(Session["userid"]);

            
            Myservice.Service1Client myservice = new Myservice.Service1Client();

            //Tobjclass Tobj = new Tobjclass();
            //IEnumerable<> myenum = myservice.LoadTask(Id);
            //Tobj.TaskList =  myservice.LoadTaskAsync(Id);

            gdv.DataSource = myservice.LoadTask(Id);
            gdv.DataBind();

            
        }

        protected void btnAddTask_Click(object sender, EventArgs e)
        {
            if (txtbxtask.Text != null && txtbxtaskdesc.Text != "")
            {
                int Id =Convert.ToInt32(Session["userid"]);
                Myservice.Service1Client myservice = new Myservice.Service1Client();
                string St=myservice.InsertTask(txtbxtask.Text, txtbxtaskdesc.Text, "High", DateTime.Now.ToString(), Id, "A");

                if (St == "Sucess")
                {
                    LoadForUser();
                    txtbxtask.Text = "";
                    txtbxtaskdesc.Text = "";
                }
                else
                {
                    lblmsg.Text = "Unable to Fetch Data Try Again";
                }
            }
            

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //LoadForUser();
        }
      
        
       
        
    }
}