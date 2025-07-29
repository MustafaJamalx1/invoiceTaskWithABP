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
    public class ProductPricingRepository : EfCoreRepository<invoiceTaskDbContext, ProductPricing, Guid>, IProductPricingRepository
    {
        private readonly IClock _clock;
        public ProductPricingRepository(IDbContextProvider<invoiceTaskDbContext> dbContextProvider, IClock clock) : base(dbContextProvider)
        {
            _clock = clock;
        }
        public async Task<ProductPricing> GetActivePricingAsync(Guid id)

        {
            var dbContext = await GetDbContextAsync();
            var today = _clock.Now;
            var productPricing = await dbContext.ProductPricings.Where(p => p.ProductId == id).Where(p => p.StartDate <= today).Where(p => p.EndDate >= today).OrderByDescending(p => p.StartDate).FirstOrDefaultAsync();
            if (productPricing == null)
            {
                throw new EntityNotFoundException(typeof(ProductPricing), id);
            }
            return productPricing;
        }



    }
}
