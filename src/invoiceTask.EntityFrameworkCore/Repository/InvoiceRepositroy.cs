using invoiceTask.Entites;
using invoiceTask.EntityFrameworkCore;
using invoiceTask.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace invoiceTask.Repository
{
    public class InvoiceRepositroy : EfCoreRepository<invoiceTaskDbContext, Invoice, Guid>, IInvoiceRepositroy
    {
        public InvoiceRepositroy(IDbContextProvider<invoiceTaskDbContext> dbContextProvider) : base(dbContextProvider)
        {
            
        }

        public async Task<List<Invoice>> GetAllWithDetailsAsync()
        {
            var queryable =await GetQueryableAsync();
            return await queryable.Include(o => o.InvoiceItems).ToListAsync();
        }

        public async Task<Invoice> GetWithDetailsAsync(Guid id)
        {
            var queryable = await GetQueryableAsync();
            var invoice = await queryable.Include(o => o.InvoiceItems).FirstOrDefaultAsync(p => p.Id == id);
            if (invoice == null)
            {
                throw new Exception($"Product with ID {id} not found.");
            }
            return invoice;

        }
    }

}
