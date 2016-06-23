using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeneralExamples.Controllers
{
    public class Class1
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
    public class Class2
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
    public class ComplexViewModel
    {
        public List<Class1> Class1List { get; set; }
        public List<Class2> Class2List { get; set; }

        public ComplexViewModel()
        {
            Class1List = new List<Class1>();
            Class2List = new List<Class2>();
        }
    }
    public class ComplexController : Controller
    {
        // GET: Complex
        public ActionResult Index()
        {
            ComplexViewModel vm = new ComplexViewModel();
            for(int i = 0; i < 10; ++i)
            {
                vm.Class1List.Add(new Class1() { Id = i + 1, Value = "C1Val " + i + 1 });
                vm.Class2List.Add(new Class2() { Id = i + 1, Value = "C2Val " + i + 1 });
            }
            return View(model:vm);
        }
    }
}