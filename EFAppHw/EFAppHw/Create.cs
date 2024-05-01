using EFAppHw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAppHw
{
    internal class Create
    {
        NorthwindContext context = new NorthwindContext();


        
        public void Category(string categoryName,string descpriton="Newly added Category")
        {

            Category newCategory = new Category()
            {
                CategoryName = categoryName,
                Description = descpriton
            };
            context.Add(newCategory);
            context.SaveChanges();
        }

    }
}
