using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace First.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Hello good Moring";
        }

        public string Index1()
        {
            return "INDEX 1 Method";
        }

        public ActionResult Login()
        {
            return View();
            // by deafult it will search view by login name
            // because action method
        }
    }
}