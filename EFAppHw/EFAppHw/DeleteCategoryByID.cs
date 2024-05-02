using EFAppHw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAppHw
{
    internal class DeleteByID
    {

        NorthwindContext context;

        public DeleteByID(NorthwindContext context)
        {
            this.context = context;
        }

        public void Category(int id) {
        
            var entry = context.Categories.Where(s=> s.CategoryId == id).FirstOrDefault();

            if (entry is Category)
            {
                // you need to add first or default
                context.Categories.Remove(entry);

            }



        }


    }
}
