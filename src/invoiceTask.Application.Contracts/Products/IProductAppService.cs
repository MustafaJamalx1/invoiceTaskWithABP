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
    }
}
