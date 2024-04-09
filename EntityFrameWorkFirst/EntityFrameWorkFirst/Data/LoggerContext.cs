using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWorkFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using static System.Net.Mime.MediaTypeNames;


namespace EntityFrameWorkFirst.Data
{
    public class LoggerContext : DbContext
    {
        public DbSet<Entry> LogEntries { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=HACQER-FARUK\\SQLEXPRESS;Database=LoggerDatabase;User Id=sa;Password=123;Encrypt=True";


            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = LoggerContext; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
        }

    }

    
}
