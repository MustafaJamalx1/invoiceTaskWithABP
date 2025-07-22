using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using invoiceTask.Entites;
using Volo.Abp.Domain.Repositories;

namespace invoiceTask.IRepos
{
    public interface IInvoiceItemRepository :IRepository<InvoiceItem,Guid>
    {
        Task<ProductPricing> GetActivePricingAsync(Guid id);
        Task<ProductDiscount> GetActiveDiscountAsync(Guid id);

    }
}
