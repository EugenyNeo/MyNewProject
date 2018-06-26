using CreateReceiptAppContext.Code;
using CreateReceiptEntities.Code;
using CreateReceiptRepositories.Generic;
using CreateReceiptRepositories.Abstract;

namespace RecipesRepositories
{
    public class ProductsRepository : DbRepository<Product>, IProductsRepository
    {
        public ProductsRepository(MyAppDbContext context)
            : base(context)
        {
        }
    }

    public class ReceiptsRepository : DbRepository<Receipt>, IReceiptsRepository
    {
        public ReceiptsRepository(MyAppDbContext context)
            : base(context)
        {
        }
    }

    public class DishesRepository : DbRepository<Dish>, IDishesRepository
    {
        public DishesRepository(MyAppDbContext context)
            : base(context)
        {
        }
    }
}
