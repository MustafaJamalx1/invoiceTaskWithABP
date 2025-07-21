using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace invoiceTask.ProductDiscounts.Dtos
{
    public class ProductDiscountDto:FullAuditedEntityDto<Guid>
    {
        public Guid ProductId { get; set; }
        public decimal Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
