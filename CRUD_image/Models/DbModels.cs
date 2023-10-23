using Microsoft.EntityFrameworkCore;

namespace CRUD_image.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Unit { get; set; } = default!;
        public string Price { get; set; } = default!;
        public byte[] Image { get; set; } = default!;
        public string ImageFile { get; set; } = default!;
    }
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext>options):base(options) 
        {
            
        }
        public DbSet<Product> Products { get; set; } = default!;
    }

}
