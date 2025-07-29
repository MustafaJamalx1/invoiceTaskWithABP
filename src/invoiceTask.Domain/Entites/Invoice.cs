using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace invoiceTask.Entites
{
    public class Invoice : FullAuditedAggregateRoot<Guid>
    {
        public string CustomerName { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalNet { get; set; }

        protected Invoice() { }
        
        public Invoice(Guid id, string customerName, int invoiceNo, DateTime invoiceDate):base(id)
        {
            CustomerName = customerName;
            InvoiceNo = invoiceNo;
            InvoiceDate = invoiceDate;
            InvoiceItems = new List<InvoiceItem>();
            TotalAmount = 0;
            TotalDiscount = 0;
            TotalNet = 0;
        }
    }
}
