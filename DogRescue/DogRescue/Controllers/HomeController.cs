using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogRescue.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //calls and renders the index view
        {
            return View();
        }

        public ActionResult AboutUs() //calls and renders the about us view
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}