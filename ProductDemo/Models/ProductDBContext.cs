using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ProductDemo.Models
{
    public class ProductDBContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVariants> ProductVariants { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
            string myDb1ConnectionString = configuration.GetConnectionString("Connection1");
            optionsBuilder.UseSqlServer(myDb1ConnectionString);
        }
    }
}
