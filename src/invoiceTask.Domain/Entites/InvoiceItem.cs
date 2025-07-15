using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace invoiceTask.Entites
{
    public class InvoiceItem: FullAuditedAggregateRoot<Guid>
    {
        public Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice => Quantity * Price;
        public decimal Discount {  get; set; }
        public decimal TotalNet => Discount * TotalPrice;
    }
}
