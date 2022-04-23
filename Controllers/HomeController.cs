using Grobble.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grobble.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "This is a test page.";


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is our contacts.";
            ViewBag.NameOfOwner = "BENREBIAI Oussama";
            ViewBag.EmailOfOwner = "mosercoser@gmail.com";

            return View();
        }

        public ActionResult Cameras()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.NameOfOwner = "BENREBIAI Oussama";
            ViewBag.EmailOfOwner = "mosercoser@gmail.com";


            return View();
        }
    }
}