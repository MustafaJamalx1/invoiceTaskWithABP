using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using invoiceTask.Entites;
using Volo.Abp.Domain.Repositories;

namespace invoiceTask.IRepos
{
    public interface IProductRepository: IRepository<Product,Guid>
    {
        Task<List<Product>> GetAllWithDetailsAsync();
    }
}
