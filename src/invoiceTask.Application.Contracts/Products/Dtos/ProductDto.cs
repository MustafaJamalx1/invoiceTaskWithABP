using invoiceTask.ProductDiscounts.Dtos;
using invoiceTask.ProductPricings.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace invoiceTask.Products.Dtos
{
    public class ProductDto: FullAuditedEntityDto<Guid>
    {

        public string Name { get; set; }
        public string Code { get; set; }
        public int PartNo { get; set; }
        public List<ProductDiscountDto> Discounts { get; set; }

        public List<ProductPricingDto> Pricings { get; set; }

    }
}
