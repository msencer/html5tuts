using Module5.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module5.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guess(int guess)
        {
            if (Session["GameObject"] == null)
                Session["GameObject"] = new GameLogic(10);

            GameLogic logic = (GameLogic)Session["GameObject"];
            
            return Json(logic.Guess(guess), JsonRequestBehavior.AllowGet);
        }

    }
}