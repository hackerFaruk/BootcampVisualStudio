using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWorkFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;


namespace EntityFrameWorkFirst.Data
{
    public class LoggerContext : DbContext
    {
        public DbSet<Entry> LogEntries { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=HACQER-FARUK\\SQLEXPRESS;Database=myDatabase;User Id=sa;Password=123;";

            optionsBuilder.UseSqlServer(connectionString);
        }

    }

    
}
