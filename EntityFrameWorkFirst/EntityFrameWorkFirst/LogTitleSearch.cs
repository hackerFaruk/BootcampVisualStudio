using EntityFrameWorkFirst.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkFirst
{
    public class LogTitleSearch
    {
        LoggerContext context;

        public LogTitleSearch(LoggerContext context)
        {
            this.context = context;
        }   

        public void TitleSearch(string searchQuery)
        {
            var entries = context.LogEntries.Where(s => s.Title.ToLower().Contains(searchQuery.ToLower())).OrderBy(s => s.Title);
            foreach (var entry in entries)
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
