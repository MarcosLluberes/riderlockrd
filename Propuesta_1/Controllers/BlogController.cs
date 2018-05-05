using Propuesta_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Propuesta_1.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Action = "Blog";
            var blogEntries = new DataInit().blogEntries;

            return View(blogEntries);
        }

        // GET: Blog/Item/{id}
        public ActionResult Item(int id)
        {
            ViewBag.Action = "Blog";
            var blogEntry = new DataInit().blogEntries.FirstOrDefault(x => x.ID == id);

            return View(blogEntry);
        }
    }
}