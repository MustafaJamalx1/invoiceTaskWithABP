using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace invoiceTask.ProductPricings.Dtos
{
    public class ProductPricingDto: FullAuditedEntityDto<Guid>
    {
        public Guid ProductId { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
