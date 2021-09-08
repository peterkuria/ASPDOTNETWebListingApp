using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDOTNETWebListingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //  optional can add return View(About);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            // note The view take the name of the View module - name of action
            return View("ContactUs");
        }
    }
}