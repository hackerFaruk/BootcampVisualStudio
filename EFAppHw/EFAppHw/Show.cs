using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFAppHw.Models;
using Microsoft.IdentityModel.Logging;
using Microsoft.VisualBasic;

namespace EFAppHw.Models;

internal class Show
{
    NorthwindContext context;

    public Show(NorthwindContext context)
    {
        this.context = context;
    }

    public void Catagories()
    {
        var catagories = context.Categories.OrderBy(p => p.CategoryName);
        

        foreach (var entry in catagories)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Id : {entry.CategoryId}");
            Console.WriteLine($"Name : {entry.CategoryName}");
            Console.WriteLine($"Body : {entry.Description}");
            var size = entry.Products.Count();

            Console.WriteLine($"Size : {size}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("######");

        }
    }


    public void Customers()
    {
        var categories = context.Customers.OrderBy(p => p.CompanyName);

        foreach (var entry in categories)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Id : {entry.CustomerId}");
            Console.WriteLine($"Company Name : {entry.CompanyName}");
            Console.WriteLine($"Contact Name : {entry.ContactName}");
            Console.WriteLine($"City : {entry.City}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("######");
            
        }
    }


    public void CustomerByRegion(string citySelection)
    {
        var categories = context.Customers
    .Where(p => p.City.ToLower().Contains(citySelection.ToLower()))
    .OrderBy(p => p.City);


        foreach (var entry in categories)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Id : {entry.CustomerId}");
            Console.WriteLine($"Company Name : {entry.CompanyName}");
            Console.WriteLine($"Contact Name : {entry.ContactName}");
            Console.WriteLine($"City : {entry.City}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("######");

        }

    }

   




}
