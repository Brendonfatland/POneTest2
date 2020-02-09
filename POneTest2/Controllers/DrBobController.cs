using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POneTest2.Models;
using System.IO;

namespace POneTest2.Controllers
{
    public class DrBobController : Controller
    {
        public ActionResult Index()
        {
            drbobContext Db = new drbobContext();
            return View(Db.Drbobs.ToList());
        }
    }
}