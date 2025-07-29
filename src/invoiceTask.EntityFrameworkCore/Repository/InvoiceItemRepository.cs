using invoiceTask.Entites;
using invoiceTask.EntityFrameworkCore;
using invoiceTask.IRepos;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace invoiceTask.Repository
{
    public class InvoiceItemRepository : EfCoreRepository<invoiceTaskDbContext, InvoiceItem, Guid>, IInvoiceItemRepository
    {
        public InvoiceItemRepository(IDbContextProvider<invoiceTaskDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
