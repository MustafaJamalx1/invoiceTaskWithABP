using invoiceTask.Entites;
using invoiceTask.IRepos;
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
    public class ProductAppService :CrudAppService<Product,ProductDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateProductDto>, IProductAppService
    {
        private readonly IProductRepository _repository;

        public ProductAppService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public async Task<List<ProductDto>> GetAllWithDetailsAsyncDto()
        {
            var products = await _repository.GetAllWithDetailsAsync();
            return products.Select(product => ObjectMapper.Map<Product, ProductDto>(product)).ToList();
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
