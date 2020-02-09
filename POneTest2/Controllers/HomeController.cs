using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POneTest2.Models;
using System.IO;

namespace POneTest2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            dentistContext Db = new dentistContext(); 
            return View(Db.Dentists.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}