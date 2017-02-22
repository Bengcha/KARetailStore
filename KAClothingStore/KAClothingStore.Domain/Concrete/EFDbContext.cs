using KAClothingStore.Domain.Entities;
using System.Data.Entity;

namespace KAClothingStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
