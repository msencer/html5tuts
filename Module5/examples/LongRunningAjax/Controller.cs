    delegate string ProcessTask(string id);
    MyLongRunningClass longRunningClass = new MyLongRunningClass();

    public void StartLongRunningProcess(string id)
    {
        longRunningClass.Add(id);            
        ProcessTask processTask = new ProcessTask(longRunningClass.ProcessLongRunningAction);
        processTask.BeginInvoke(id, new AsyncCallback(EndLongRunningProcess), processTask);
    }
    public void EndLongRunningProcess(IAsyncResult result)
    {
        ProcessTask processTask = (ProcessTask)result.AsyncState;
        string id = processTask.EndInvoke(result);
        longRunningClass.Remove(id);
    }
    public ContentResult GetCurrentProgress(string id)
    {
        this.ControllerContext.HttpContext.Response.AddHeader("cache-control", "no-cache");
        var currentProgress = longRunningClass.GetStatus(id).ToString();
        return Content(currentProgress);
    }
