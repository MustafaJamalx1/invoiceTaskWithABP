using invoiceTask.Entites;
using invoiceTask.ProductPricings.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace invoiceTask.ProductPricings
{
    public class ProductPricingAppService : CrudAppService<ProductPricing, ProductPricingDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductPricingDto>, IProductPricingAppService
    {
        public ProductPricingAppService(IRepository<ProductPricing, Guid> repository) : base(repository)
        {
            
        }
    }
}
