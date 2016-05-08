
using System.Data.Entity;
using BuildSeller.Core.Model;

namespace BuildSeller.Models
{

    public class WebShopContext : DbContext
    {

        public WebShopContext()
            : base("name=WebBuildingsContext")
        {
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<ProductCategories> BuildCategories { get; set; }

        public DbSet<Product> Realties { get; set; }

        public DbSet<Subscribe> Subscribes { get; set; }
    }
}
