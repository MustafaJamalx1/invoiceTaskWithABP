using invoiceTask.Entites;
using invoiceTask.IRepos;
using invoiceTask.ProductPricings.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace invoiceTask.ProductPricings
{
    public class ProductPricingAppService : CrudAppService<ProductPricing, ProductPricingDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductPricingDto>, IProductPricingAppService
    {
        private readonly IProductPricingRepository _productPricingRepository;
        public ProductPricingAppService(IProductPricingRepository repository) : base(repository)
        {
            
            _productPricingRepository = repository;
        }
    }
}
