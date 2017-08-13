using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeadsWeb.Models
{
    [Table("contactleads")]
    public class ContactLeadsModel
    {
        [Required]
        [Key]
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
        public string optmzd_id { get; set; }
        public string gclid { get; set; }
        public string RContact_CreatedDate { get; set; }
        public DateTime InsertDate { get; set; }
        public Boolean IsSent { get; set; }
        public string ReturnSent { get; set; }
        public string ErrorSent { get; set; }
    }
}
