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
    internal class Program
    {
        static void Main(string[] args)
        {

            // this comes from LoggerContext file  which basiclly builds db
            using LoggerContext context = new LoggerContext();

            // this comes from LogAdder.cs to make easier to add new entries
            LogAdder logAdder = new LogAdder();


            Console.WriteLine("Hello, World!");
        }
    }
}
