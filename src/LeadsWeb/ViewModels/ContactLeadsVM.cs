using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeadsWeb.ViewModels
{
    public class ContactLeadsVM
    {
        public int RContact_ID { get; set; }
        public string Source { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string RContact_DayTime { get; set; }
        public string RContact_Destination { get; set; }
        public string product_description { get; set; }
        public string Address { get; set; }
        public string RContact_Remark1 { get; set; }
        public string RContact_Remark2 { get; set; }
        public Boolean IsReject { get; set; }
        public string RejectReason { get; set; }
        public string RContact_CreatedDate { get; set; }
        public Boolean IsSent { get; set; }
        public string ReturnSent { get; set; }
    }
}
