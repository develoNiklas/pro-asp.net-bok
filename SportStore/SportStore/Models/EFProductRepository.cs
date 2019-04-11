using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
namespace SportStore.Models
{
    public class EFProductRepository : IProductRepository
    {
        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
