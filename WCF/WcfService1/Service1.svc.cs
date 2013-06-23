using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Yapp_On_DAL;
using WcfService1.ServiceModels;


namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string Test(string value)
        {
            return "Hai " + value;
        }

        public string InsertUser(string Username,string Mailid)
        {
            string Result = "a";
            DBManager DbObj=new DBManager();

            DbParameter[] dbparms = new DbParameter[2];

            dbparms[0] = DbObj.CreateParameter("@Username", Username);
            dbparms[1] = DbObj.CreateParameter("@UserMail", Mailid);
            Result = DbObj.ExecuteScalar("InsertUser", dbparms, CommandType.StoredProcedure).ToString();

            return Result;

        }
        public int Getuserbymail(string Mailid)
        {
            int Result;
            DBManager DbObj = new DBManager();

            DbParameter[] dbparms = new DbParameter[1];

            dbparms[0] = DbObj.CreateParameter("@Mail", Mailid);
            Result = Convert.ToInt32(DbObj.ExecuteScalar("GetUserbyMail", dbparms, CommandType.StoredProcedure));

            return Result;

        }

        public string InsertTask(string Task, string Task_Descriprtion, string Priority, string Time, int UserId,string Status)
        {
            string Result = "";

            DBManager DbObj = new DBManager();

            DbParameter[] dbparms = new DbParameter[6];
            dbparms[0] = DbObj.CreateParameter("@Task", Task);
            dbparms[1] = DbObj.CreateParameter("@Task_Desc", Task_Descriprtion);
            dbparms[2] = DbObj.CreateParameter("@Priority", Priority);
            dbparms[3] = DbObj.CreateParameter("@Time", Time);
            dbparms[4] = DbObj.CreateParameter("@userid", UserId);
            dbparms[5] = DbObj.CreateParameter("@Status", Status);

            Result = DbObj.ExecuteScalar("InsertTask", dbparms, CommandType.StoredProcedure).ToString();

            return Result;

        }

        public List<WcfService1.ServiceModels.TaskCls> LoadTask(int UserId)
        {
            DataSet dset = new DataSet();
            DataTable dt = new DataTable();

            DBManager DbObj = new DBManager();

            DbParameter[] dbparms = new DbParameter[1];
            dbparms[0] = DbObj.CreateParameter("@Userid", UserId);

            dt = DbObj.GetDataTabe("GetTask", dbparms, CommandType.StoredProcedure);
            
            List<TaskCls> TaskList = new List<TaskCls>();
            foreach (DataRow dr in dt.Rows)
            {
                TaskList.Add(new TaskCls
                {
                    Task = (dr["Task"].ToString()),
                    Task_Des = (dr["Task_Des"].ToString()),
                    Priority = (dr["Priority"].ToString()),
                    CurrentTime = (dr["CurrentTime"].ToString()),
                    Active_Status = (dr["Active_Status"].ToString())


                });

            }
            return TaskList;


        }

        
    }
}
