using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDOTNETWebListingApp.Controllers
{
    public class GadgetsController : Controller
    {
        // GET: Gadgets
        public ActionResult Index()
        {
            return View();
        }
    }
}