using System.Collections.Generic;
using KAClothingStore.Domain.Entities;

namespace KAClothingStore.Domain.Abstract
{
    public interface IProductsRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
