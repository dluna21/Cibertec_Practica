using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebContextDb : DbContext
    {
        public WebContextDb() : base("name=WebDeveloperConnectionString")
        {
        }
        public DbSet<Category> Categorie { get; set; }
        public DbSet<Customers> Customer { get; set; }
        public DbSet<Employees> Employee { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<Products> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
