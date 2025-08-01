using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using invoiceTask.Entites;
using invoiceTask.EntityFrameworkCore;
using invoiceTask.IRepos;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace invoiceTask.Repository
{
    public class ProductRepository : EfCoreRepository<invoiceTaskDbContext, Product, Guid>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<invoiceTaskDbContext> dbContextProvider): base(dbContextProvider) { }
        public async Task<List<Product>> GetAllWithDetailsAsync()
        {
            var queryable = await GetQueryableAsync();

            return await queryable.Include(o => o.Pricings).Include(o => o.Discounts).ToListAsync();
        }

        public async Task<Product> GetWithDetailsAsync(Guid id)
        {
            var queryable = await GetQueryableAsync();
            var product = await queryable.Include(o => o.Pricings).Include(o => o.Discounts).FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                throw new Exception($"Product with ID {id} not found.");
            }
            return product;
        }
    }
}
