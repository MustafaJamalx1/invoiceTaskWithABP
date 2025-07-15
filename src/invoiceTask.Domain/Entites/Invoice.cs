using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace invoiceTask.Entites
{
     public class Invoice: FullAuditedAggregateRoot<Guid>
    {
        public string CustomerName { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }=new List<InvoiceItem>();

        public decimal TotalAmount => InvoiceItems.Sum(i => i.TotalPrice);
        public decimal TotalDicsount=> InvoiceItems.Sum(i => i.Discount);
        public decimal TotalNet=> InvoiceItems.Sum(i => i.TotalPrice);

    }
}
