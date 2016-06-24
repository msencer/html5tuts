using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularExamples.Controllers
{
    public class Urun
    {
        public string UrunAd { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
    }

    public class Sepet {
        public List<Urun> Urunler { get; set; }
    }
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
            return View();
        }

        public ActionResult GetYemekler()
        {
            return Json(DummyUrunOlustur(), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult SiparisVer(Sepet sep)
        {
            return Json(sep, JsonRequestBehavior.AllowGet);
        }
    }
}