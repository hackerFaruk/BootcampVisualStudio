﻿using System;
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
            LogAdder logAdder = new LogAdder(context);

            // this comes from log vievwr
            LogViewer logViewer = new LogViewer(context);  

            // this from logtitle serach
            LogTitleSearch titleSearcher = new LogTitleSearch(context);


           

          

        


           

        }


        static void basicTest()
        {
            Console.WriteLine("test");
            // this comes from LoggerContext file  which basiclly builds db
            using LoggerContext context = new LoggerContext();

            // this comes from LogAdder.cs to make easier to add new entries
            LogAdder logAdder = new LogAdder(context);

            // this comes from log vievwr
            LogViewer logViewer = new LogViewer(context);

            // this from logtitle serach
            LogTitleSearch titleSearcher = new LogTitleSearch(context);



            Console.WriteLine("this is log text adds 3 log entrierse");
            logAdder.AddNewLog("İlk not", "bu not ilk notum");
            logAdder.AddNewLog("ikinci not", "bu not ikinci notum");
            logAdder.AddNewLog("üçüncü not", "bu not üçünüc notum");



            Console.WriteLine(" shows logss");

            logViewer.ViewLog();

            Console.WriteLine(" ssss");
            Console.WriteLine(" ssss");
            Console.WriteLine(" ssss");



            Console.WriteLine(" searchs for ilk  on title ");
            titleSearcher.TitleSearch("ilk");


        }



       


    }
}
