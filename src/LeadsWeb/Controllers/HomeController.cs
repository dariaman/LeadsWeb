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
            ContactLeadsVM contac = new ContactLeadsVM();
            contac = ( from c in _context.ContactLeadsModel
                       select new ContactLeadsVM()
                       {
                           Source = c.Source,
                           Name=c.Name,
                           Gender=c.Gender,
                           DOB=c.DOB,
                           Phone=c.Phone,
                           Email=c.Email,
                           RContact_DayTime=c.RContact_DayTime,
                           RContact_Destination=c.RContact_Destination,
                           RContact_CreatedDate=c.RContact_CreatedDate
                       }).ToList();
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
