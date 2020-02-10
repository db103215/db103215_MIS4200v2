using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace db103215_mis4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My name is Dylan Bryan.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Dylan Bryan.";

            return View();
        }
    }
}