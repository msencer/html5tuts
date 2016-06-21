using System.Collections.Generic;
using System.Linq;
using System.Threading;
public class LongRunningClass
{

    private static object syncRoot = new object();

    private static IDictionary<string, int> ProcessStatus { get; set; }

    public LongRunningClass()
    {
        if (ProcessStatus == null)
        {
            ProcessStatus = new Dictionary<string, int>();
        }
    }

    public string ProcessLongRunningAction(string id)
    {
        for (int i = 1; i <= 100; i++)
        {
            Thread.Sleep(100);
            lock (syncRoot)
            {
                ProcessStatus[id] = i;
            }
        }
        return id;
    }

    
    public void Add(string id)
    {
        lock (syncRoot)
        {
            ProcessStatus.Add(id, 0);
        }
    }

    
    public void Remove(string id)
    {
        lock (syncRoot)
        {
            ProcessStatus.Remove(id);
        }
    }

    public int GetStatus(string id)
    {
        lock (syncRoot)
        {
            if (ProcessStatus.Keys.Count(x => x == id) == 1)
            {
                return ProcessStatus[id];
            }
            else
            {
                return 100;
            }
        }
    }
}
