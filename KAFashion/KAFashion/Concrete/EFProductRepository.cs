using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KAFashion.Abstract;
using KAFashion.Models;

namespace KAFashion.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}