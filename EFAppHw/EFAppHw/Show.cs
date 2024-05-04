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

    public void Categories()
    {
        var categories = context.Categories.OrderBy(p => p.CategoryName);
        

        foreach (var entry in categories)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Id : {entry.CategoryId}");
            Console.WriteLine($"Name : {entry.CategoryName}");
            Console.WriteLine($"Body : {entry.Description}");
            Console.WriteLine($"Count : {entry.Products.Count()}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("######");

        }
    }

    public void CategoryProductCount()
    {
        var categories = context.Categories
                        .OrderBy(p => p.CategoryName)
                        .Select(category => new
                        {
                            CategoryName = category.CategoryName,
                            ProductCount = category.Products.Count()
                        })
                        .ToList();

        foreach (var entry in categories)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Category : {entry.CategoryName}");
            Console.WriteLine($"Count : {entry.ProductCount}");
          
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



    public void Products()
    {
        var Products = context.Products.OrderBy(p => p.ProductName);
        foreach(var entry in Products)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Id : {entry.ProductId}");
            Console.WriteLine($"Product Name : {entry.ProductName}");
            
            if (entry.Category != null)
            {
                Console.WriteLine($"Category Name : {entry.Category.CategoryName}");
            }
            else
            {
                Console.WriteLine("Category Name : Not Available");
            }

           
            if (entry.UnitsOnOrder.HasValue)
            {
                Console.WriteLine($"Order Amount : {entry.UnitsOnOrder.Value}");
            }
            else
            {
                Console.WriteLine("Order Amount : Not Available");
            }
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

    public void CategoryByName(string categoryName)
    {
        var categories = context.Categories
    .Where(p => p.CategoryName.ToLower().Contains(categoryName.ToLower()))
    .OrderBy(p => p.CategoryName);


        foreach (var entry in categories)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Id : {entry.CategoryId}");
            Console.WriteLine($"Name : {entry.CategoryName}");
            Console.WriteLine($"Body : {entry.Description}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("######");


        }

    }






}
