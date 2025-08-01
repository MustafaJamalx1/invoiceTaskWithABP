using invoiceTask.ProductDiscounts.Dtos;
using invoiceTask.ProductPricings.Dtos;
using invoiceTask.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace invoiceTask.Products
{
    public interface IProductAppService:ICrudAppService<ProductDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateProductDto>
    {
        Task<List<ProductDto>> GetAllWithDetailsAsyncDto();
        Task<ProductPricingDto> AddProductPricingAsync(CreateUpdateProductPricingDto input);
        Task<ProductPricingDto> RemoveProductPricingAsync(Guid Id);
        Task<ProductDiscountDto> AddProductDiscountAsync(CreateUpdateProductDiscountDto input);
        Task<ProductDiscountDto> RemoveProductDiscountAsync(Guid Id);



    }
}
