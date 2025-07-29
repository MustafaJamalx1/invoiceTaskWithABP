using invoiceTask.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace invoiceTask.IRepos
{
    public interface IProductDiscountRepository :IRepository<ProductDiscount, Guid>
    {
        Task<ProductDiscount> GetActiveDiscountAsync(Guid id);
    }
}
