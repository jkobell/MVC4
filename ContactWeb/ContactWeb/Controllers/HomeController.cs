using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message1 = "James Kobell - Application Developer";
            ViewBag.Message2 = "BS Information Technology-.NET Application Development ";
            ViewBag.Message3 = "Microsoft Certification-Software Development Fundamentals";
            ViewBag.Message4 = "C# - MVC - CORE - SQL - WEB.API";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Check us out on LinkedIn - Contact Us - Take a look at the GitHub projects";

            return View();
        }
    }
}