using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace invoiceTask.InvoiceItems.Dtos
{
    public class InvoiceItemDto : FullAuditedEntityDto<Guid>
    {
       
            public Guid InvoiceId { get; set; }
            public Guid ProductId { get; set; }
            public int Quantity { get; set; }
            public decimal Discount { get; set; }
            public decimal Price { get; set; }
            public decimal TotalPrice { get; set; }
            public decimal TotalNet { get; set; }



    }
    
}