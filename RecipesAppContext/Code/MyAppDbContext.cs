using CreateReceiptEntities.Code;
using System.Data.Entity;

namespace CreateReceiptAppContext.Code
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Receipt> Recipes { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        public MyAppDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
        static MyAppDbContext()
        {
            Database.SetInitializer(new MyAppDbContextInitializer());
        }
    }
}
