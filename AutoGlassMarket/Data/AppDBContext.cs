using AutoGlassMarket.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoGlassMarket.Content
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }


        public DbSet<CarsBrand> allCarsRP { get; set; }
        public DbSet<Glasses> allGlassesRP { get; set; }
        public DbSet<Buyers> allBuyersRP { get; set; }
    }
}

