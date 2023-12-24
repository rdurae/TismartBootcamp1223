using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCTismartLibrary.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            ViewBag.UserName = "Rodrigo";
            return View();
            
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

        [HttpGet]
        public ActionResult Modal()
        {
//            ViewBag.Message = "Your contact page.";

            return PartialView("_Modal");
        }
    }
}