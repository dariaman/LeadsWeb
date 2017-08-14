using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LeadsWeb.Data;
using LeadsWeb.ViewModels;

namespace LeadsWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<ContactLeadsVM> contac;
            //ContactLeadsVM contac = new ContactLeadsVM();
            contac = ( from c in _context.ContactLeadsModel
                       select new ContactLeadsVM()
                       {
                           RContact_ID=c.RContact_ID,
                           Source = c.Source,
                           Name=c.Name,
                           Gender = c.Gender,
                           DOB = c.DOB,
                           Phone = c.Phone,
                           Email = c.Email,
                           RContact_DayTime = c.RContact_DayTime,
                           RContact_Destination = c.RContact_Destination,
                           product_description = c.product_description,
                           Address = c.Address,
                           RContact_Remark1 = c.RContact_Remark1,
                           RContact_Remark2 = c.RContact_Remark2,
                           IsReject = c.IsReject,
                           RejectReason = c.RejectReason,
                           IsSent = c.IsSent,
                           //ReturnSent = c.ReturnSent.Substring(0, 50),
                           RContact_CreatedDate = c.RContact_CreatedDate
                       });
            return View(contac);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
