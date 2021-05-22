using Entities.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class TrendyolAppDbContext : DbContext
    {
        public TrendyolAppDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<CarouselAd> CarouselAds { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubSubCategory> SubSubCategories { get; set; }


    }
}
