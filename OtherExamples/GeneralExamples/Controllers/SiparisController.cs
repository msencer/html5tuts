using GeneralExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralExamples.Controllers
{
    public class SiparisController : Controller
    {
        // GET: Siparis
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Siparis sip)
        {
            return new EmptyResult();
        }
    }
}