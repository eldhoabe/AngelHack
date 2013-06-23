using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.ServiceModels
{
    public class TaskCls
    {
        #region Properties 

        public string Task { get; set; }
        public string Task_Des { get; set; }
        public string Priority { get; set; }
        public string CurrentTime { get; set; }
        public int User_Id { get; set; }
        public string Active_Status { get; set; }

        public List<TaskCls> TaskList { get; set; }

        #endregion
    }
}