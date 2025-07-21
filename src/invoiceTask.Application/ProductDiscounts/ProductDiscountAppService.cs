using invoiceTask.Entites;
using invoiceTask.ProductDiscounts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace invoiceTask.ProductDiscounts
{
    public class ProductDiscountAppService : CrudAppService<ProductDiscount,ProductDiscountDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateProductDiscountDto>,IProductDiscountAppService
    {
        public ProductDiscountAppService(IRepository<ProductDiscount,Guid> repository):base(repository)
        {
            
        }
    }
}
