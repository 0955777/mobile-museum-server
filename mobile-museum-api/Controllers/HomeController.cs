using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mobile_museum_api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
