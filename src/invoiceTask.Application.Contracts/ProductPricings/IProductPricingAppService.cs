using invoiceTask.ProductPricings.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace invoiceTask.ProductPricings
{
    public interface IProductPricingAppService:ICrudAppService<ProductPricingDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductPricingDto>
    {
    }
}
