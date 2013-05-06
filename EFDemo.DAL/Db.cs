using System.Data.Entity;
using EFDemo.Model;

namespace EFDemo.DAL
{
    public class Db : DbContext
    {
        public Db() : base("DemoDb") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
