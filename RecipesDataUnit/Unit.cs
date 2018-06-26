using CreateReceiptAppContext.Code;
using CreateReceiptRepositories;
using ReceiptsRepositories.Abstract;

namespace CreateReceiptDataUnit
{
    public static class Unit
    {
        static MyAppDbContext _context;
        public static IProductsRepository ProductsRepository { get; private set; }
        public static IReceiptsRepository ReceiptsRepository { get; private set; }
        public static IDishesRepository DishesRepository { get; private set; }

        static Unit()
        {
            _context = new MyAppDbContext("Receipt");
            ProductsRepository = new ProductsRepository(_context);
            ReceiptsRepository = new ReceiptsRepository(_context);
            DishesRepository = new DishesRepository(_context);
        }
    }
}
