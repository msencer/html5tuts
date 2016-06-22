using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module5.Controllers
{
    public class TimeController : Controller
    {
        // GET: Time
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTime()
        {
            return new ContentResult() { Content = DateTime.Now.TimeOfDay.ToString() };
        }
    }
}