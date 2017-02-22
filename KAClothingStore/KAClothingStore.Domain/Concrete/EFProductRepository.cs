using System.Collections.Generic;
using KAClothingStore.Domain.Abstract;
using KAClothingStore.Domain.Entities;


namespace KAClothingStore.Domain.Concrete
{
    public class EFProductRepository : IProductsRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
