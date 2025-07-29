using invoiceTask.Entites;
using invoiceTask.EntityFrameworkCore;
using invoiceTask.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Timing;

namespace invoiceTask.Repository
{
    public class ProductDiscountRepository : EfCoreRepository<invoiceTaskDbContext, ProductDiscount, Guid>, IProductDiscountRepository
    {
        private readonly IClock _clock;
        public ProductDiscountRepository(IDbContextProvider<invoiceTaskDbContext> dbContextProvider, IClock clock) : base(dbContextProvider)
        {
            _clock = clock;
        }
        public async Task<ProductDiscount> GetActiveDiscountAsync(Guid id)

        {
            var dbContext = await GetDbContextAsync();
            var today = _clock.Now;
            var prouductDiscount = await dbContext.ProductDiscounts.Where(p => p.ProductId == id).Where(p => p.StartDate <= today).Where(p => p.EndDate <= today).OrderByDescending(p => p.StartDate).FirstOrDefaultAsync();
            if (prouductDiscount == null)
            {
                throw new EntityNotFoundException(typeof(ProductDiscount), id);
            }
            return prouductDiscount;
        }


    
    }
}
