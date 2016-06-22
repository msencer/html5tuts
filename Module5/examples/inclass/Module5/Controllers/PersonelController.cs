using Module5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module5.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        public ActionResult Index()
        {
            return View();
        }

       /* [HttpPost]
        public ActionResult Add(FormCollection fc)
        {
            var result = "Gelen data : \nAd Soyad:{0}\nTelefon:{1}\n";
            return new ContentResult() { Content = string.Format(result, fc["adSoyad"], fc["tel"]),ContentType="text/plain" };
        }*/

        [HttpPost]
        public ActionResult Add(Personel model)
        {
            var result = "Gelen data : \nAd Soyad:{0}\nTelefon:{1}\n";
            return new ContentResult() { Content = string.Format(result, model.adSoyad, model.tel), ContentType = "text/plain" };
        }
    }
}