using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularExamples.Controllers
{
    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public long birthDay { get; set; }
    }
    public class HomeController : Controller
    {
        private static List<Person> personList = new List<Person>(){
            new Person() {name="Osman",surname="Aydemir",birthDay=1466760486909 },
            new Person() {name="Gökhan",surname="Gümüş",birthDay=665704800000 },
            new Person() {name="Erkan",surname="Şen",birthDay=571010400000 }
        };
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public void SavePerson(Person obj) {
            personList.Add(obj);
        }

        public ActionResult GetPersonList()
        {
            return Json(personList, JsonRequestBehavior.AllowGet);
        }
    }
}