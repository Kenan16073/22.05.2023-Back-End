using Microsoft.EntityFrameworkCore;
using P138AllupProject.Models;

namespace P138AllupProject.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }


        public DbSet<Setting> Settings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsTag> ProductsTags { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }





    }
}
