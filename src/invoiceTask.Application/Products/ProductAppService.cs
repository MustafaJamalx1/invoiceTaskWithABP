using invoiceTask.Entites;
using invoiceTask.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace invoiceTask.Products
{
    public class ProductAppService : CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto>, IProductAppService
    {
        private readonly IRepository<Product, Guid> _repository;

        public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
        {
            _repository = repository;
        }

        //protected override async Task<Product> GetEntityByIdAsync(Guid id)
        //{
        //    // Ensure ProductDiscounts are included when fetching a Product
        //    var queryable = await _repository.GetQueryableAsync();
        //    return await queryable
        //        .IncludeDetails() // Remove the parameter 'true' as it is not needed
        //        .FirstOrDefaultAsync(p => p.Id == id);
        //}  
    }
  
}
