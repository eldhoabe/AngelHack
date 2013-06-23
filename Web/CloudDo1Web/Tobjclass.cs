using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudDo1Web
{
    public class Tobjclass
    {

        public string Task { get; set; }
        public string Task_Des { get; set; }
        public string Priority { get; set; }
        public string CurrentTime { get; set; }
        public int User_Id { get; set; }
        public string Active_Status { get; set; }

        public List<Tobjclass> TaskList { get; set; }
    }
}