using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module5.Controllers
{
    public class LongController : Controller
    {

        delegate string ProcessTask(string id);
        private LongRunningClass obj = new LongRunningClass();
        public ActionResult Index()
        {
            return View();
        }

        public void StartProcess(string id)
        {
            obj.Add(id);
            ProcessTask task = new ProcessTask(obj.ProcessLongRunningAction);
            task.BeginInvoke(id, new AsyncCallback(EndProcess), task);
        }
        public void EndProcess(IAsyncResult result)
        {
            ProcessTask processTask = (ProcessTask)result.AsyncState;
            string id = processTask.EndInvoke(result);
            obj.Remove(id);
        }

        public ActionResult GetStatus(string id)
        {
            Response.AddHeader("cache-control", "no-cache");
            var stat = obj.GetStatus(id);
            return Content(stat.ToString());
        }
    }
}