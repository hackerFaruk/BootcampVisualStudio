using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// use models and data 
using EntityFrameWorkFirst.Data;
using EntityFrameWorkFirst.Models;

// you need to create context to create new log but update database


namespace EntityFrameWorkFirst
{
    
    public class LogAdder
    {

        public void AddNewLog(String title , String body, LoggerContext context)
        {
            // creates new entry model
            Entry newEntry = new Entry()
            {
                Title = title,
                Body = body
            };
            context.Add(newEntry);
            context.SaveChanges();
        }
    }
}
