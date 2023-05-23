using JuanFrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace JuanFrontToBack.DEL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderContent> SliderContents { get; set; }
        public DbSet<ProductImg> ProductImgs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }


    }
}
