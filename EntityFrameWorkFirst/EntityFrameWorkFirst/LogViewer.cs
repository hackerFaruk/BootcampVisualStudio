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
        public void ViewLog( LoggerContext context)
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
