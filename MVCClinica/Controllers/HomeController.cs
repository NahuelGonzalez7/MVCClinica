using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCClinica.Filters;
using MVCClinica.Admin;
using MVCClinica.Data;

namespace MVCClinica.Controllers
{
    public class HomeController : Controller
    {
        private static DbMedicoContext context = new DbMedicoContext();
        // GET: Home
        [MyFilterAction]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}