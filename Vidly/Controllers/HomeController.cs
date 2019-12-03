using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers {
    public class HomeController : Controller {
        //public ActionResult Index( string id ) {
        //    //return View();
        //    return Content("Hello From Home/Index" + id);
        //}

        public ActionResult Index(string id) {
            ViewBag.Countries = new List<string> {
               "India",
               "US",
               "Australia",
               "China"
           };

           return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}