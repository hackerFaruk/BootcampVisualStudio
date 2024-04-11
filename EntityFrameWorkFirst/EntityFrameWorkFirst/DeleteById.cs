using EntityFrameWorkFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using EntityFrameWorkFirst.Data;

namespace EntityFrameWorkFirst
{
    public class DeleteById
    {



        LoggerContext context;

        public DeleteById(LoggerContext context)
        {
            this.context = context;
        }

        public void TitleSearch(int id, String body)
        {
            var entry = context.LogEntries.Where(s => s.Id == id).FirstOrDefault();

            if (entry is Entry)
            {
                // you need to add first or default
                context.LogEntries.Remove(entry);

            }


         


        }



    }
}
