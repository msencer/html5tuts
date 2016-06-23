using GeneralExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralExamples.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ogrenci obj)
        {
            if (ModelState.IsValid)
            {
                return Content("Kayıt eklendi");
            }
            
            return RedirectToAction("Index");
        }
    }
}