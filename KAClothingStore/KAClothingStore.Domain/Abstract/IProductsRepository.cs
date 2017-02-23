using System.Collections.Generic;
using KAClothingStore.Domain.Entities;

namespace KAClothingStore.Domain.Abstract
{
    public interface IProductsRepository
    {
        IEnumerable<Product> Products { get; }
        void SaveProduct(Product product);
        Product DeleteProduct(int productID);
    }
}
