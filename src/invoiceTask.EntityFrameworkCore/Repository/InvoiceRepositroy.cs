using invoiceTask.Entites;
using invoiceTask.EntityFrameworkCore;
using invoiceTask.IRepos;
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
    }

}
