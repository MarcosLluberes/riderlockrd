using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Propuesta_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Action = "Index";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Action = "About";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Action = "Contact";

            return View();
        }

        public ActionResult Portofolio()
        {
            ViewBag.Action = "Portofolio";

            return View();
        }
    }
}