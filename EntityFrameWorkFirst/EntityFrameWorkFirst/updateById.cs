using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using EntityFrameWorkFirst.Data;
using EntityFrameWorkFirst.Models;

namespace EntityFrameWorkFirst
{
    public class UpdateById
    {


        LoggerContext context;

        public UpdateById(LoggerContext context)
        {
            this.context = context;
        }

        public void TitleSearch(int id, String body)
        {
            var entry = context.LogEntries.Where(s => s.Id ==id).FirstOrDefault();

            if ( entry is Entry)
            {
                // you need to add first or default
              entry.Body = body;

            }


            Console.WriteLine("updated entry");
            Console.WriteLine($"Id : {entry.Id}");
            Console.WriteLine($"Title : {entry.Title}");
            Console.WriteLine($"Body : {entry.Body}");


        }
    }
}
