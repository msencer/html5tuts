using GeneralExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralExamples.Controllers
{
    public class YemekSepetiController : Controller
    {
        private IEnumerable<Urun> DummyUrunOlustur()
        {
            var r = new Random();
            for (int i = 0; i < 10; i++)
                yield return new Urun()
                {
                    Adet = r.Next(1, 100),
                    Fiyat = (decimal)r.NextDouble() * 50,
                    UrunAd = "Yemek " + r.Next(4, 44) + i
                };
        }
        // GET: YemekSepeti
        public ActionResult Index()
        {
            return View(model:DummyUrunOlustur());
        }
    }
}