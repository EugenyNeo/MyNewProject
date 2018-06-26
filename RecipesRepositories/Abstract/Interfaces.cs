using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateReceiptDomainAbstractions.Repositories;
using CreateReceiptEntities.Code;

namespace CreateReceiptRepositories.Abstract
{
    public interface IProductsRepository : IDbRepository<Product>
    {
    }
    public interface IReceiptsRepository : IDbRepository<Receipt>
    {
    }
    public interface IDishesRepository : IDbRepository<Dish>
    {
    }
}
