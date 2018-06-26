using System.Data.Entity;

namespace CreateReceiptAppContext.Code
{
    public class MyAppDbContextInitializer : DropCreateDatabaseIfModelChanges<MyAppDbContext>
    {
        protected override void Seed(MyAppDbContext context)
        {

        }
    }
}
