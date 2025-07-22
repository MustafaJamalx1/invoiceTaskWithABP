using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace invoiceTask.InvoiceItems.Dtos
{
    public class InvoiceItemdto : FullAuditedEntityDto<Guid>
    {
       
            public Guid InvoiceId { get; set; }
            public Guid ProductId { get; set; }
            public int Quantity { get; set; }

            public Guid ProductPricingsId {  get; private set; }
            public decimal Price { get; private set; }

            public Guid ProductPricingId { get;  private set; }
            public decimal Discount { get; private set; }
        
    }
    
}