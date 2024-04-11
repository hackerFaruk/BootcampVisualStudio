using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// use models and data 
using EntityFrameWorkFirst.Data;
using EntityFrameWorkFirst.Models;

namespace EntityFrameWorkFirst
{
    public class LogViewer
    {
        LoggerContext context;

        public LogViewer(LoggerContext context) {
            this.context = context;
        }

        public void ViewLog()
        {
            var entries = context.LogEntries.OrderBy(p => p.Title);
            foreach(var entry in entries)
            {
                Console.WriteLine($"Id : {entry.Id}");
                Console.WriteLine($"Title : {entry.Title}");
                Console.WriteLine($"Body : {entry.Body}");
                Console.WriteLine("######");
                Console.WriteLine("######");
                Console.WriteLine("######");
            }
        }
    }
}
