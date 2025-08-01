using invoiceTask.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace invoiceTask.IRepos
{
    public interface IInvoiceRepositroy : IRepository<Invoice, Guid>
    {
        Task<List<Invoice>> GetAllWithDetailsAsync();
        Task<Invoice> GetWithDetailsAsync(Guid id);
    }
}
