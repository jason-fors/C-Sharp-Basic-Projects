using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Let's face it, insurance is a commodity. Find out if ours is the most affordable.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hopefully you won't be needing this contact information!";

            return View();
        }
    }
}