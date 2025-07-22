using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using invoiceTask.Entites;
using invoiceTask.EntityFrameworkCore;
using invoiceTask.IRepos;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Timing;

namespace invoiceTask.Repository
{
    public class InvoiceItemRepository : EfCoreRepository<invoiceTaskDbContext, InvoiceItem, Guid>, IInvoiceItemRepository
    {
        private readonly IClock _clock;
        public InvoiceItemRepository(IDbContextProvider<invoiceTaskDbContext> dbContextProvider, IClock clock) : base(dbContextProvider)
        {
            _clock = clock;
        }

        public async Task<ProductPricing> GetActivePricingAsync(Guid id)
           
        {
            var dbContext = await GetDbContextAsync();
            var today = _clock.Now;
            var productPricing = await dbContext.ProductPricings.Where(p => p.Id == id).Where(p => p.StartDate <= today).Where(p => p.EndDate <= today).OrderByDescending(p => p.StartDate).FirstOrDefaultAsync();
            if (productPricing == null) {
                throw new EntityNotFoundException(typeof(ProductPricing), id);
                 }
            return productPricing;
        }
        public async Task<ProductDiscount> GetActiveDiscountAsync(Guid id)

        {
            var dbContext = await GetDbContextAsync();
            var today = _clock.Now;
            var productDiscount = await dbContext.ProductDiscounts.Where(p => p.Id == id).Where(p => p.StartDate <= today).Where(p => p.EndDate <= today).OrderByDescending(p => p.StartDate).FirstOrDefaultAsync();
            if (productDiscount == null)
            {
                throw new EntityNotFoundException(typeof(ProductDiscount), id);
            }
            return productDiscount;
        }


    }
}
