using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Propuesta_1.Controllers
{
    public class MiscController : Controller
    {
        // GET: Misc/GetMenu
        public ActionResult GetMenu(string id)
        {
            ViewBag.Action = id;
            return PartialView();
        }
    }
}