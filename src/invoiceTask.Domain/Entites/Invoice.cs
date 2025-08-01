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
        public string CustomerName { get; private set; }
        public int InvoiceNo { get; private set; }
        public DateTime InvoiceDate { get; private set; }
        public ICollection<InvoiceItem> InvoiceItems { get; private set; }
        public decimal TotalAmount { get; private set; }
        public decimal TotalDiscount { get; private set; }
        public decimal TotalNet { get; private set; }

        protected Invoice() { }
        
        public Invoice( string customerName, int invoiceNo, DateTime invoiceDate)
        {
            Id = Guid.NewGuid();
            CustomerName = customerName;
            InvoiceNo = invoiceNo;
            InvoiceDate = invoiceDate;
            InvoiceItems = new List<InvoiceItem>();
            TotalAmount = 0;
            TotalDiscount = 0;
            TotalNet = 0;
        }
        public void AddInvoiceItem(
            InvoiceItem invoiceItem)
        {
            var item = new InvoiceItem(
                this.Id,
                invoiceItem.ProductId,
                invoiceItem.Quantity,
                invoiceItem.ProductPricingId,
                invoiceItem.Price,
                invoiceItem.ProductDiscountId,
                invoiceItem.Discount
            );
            InvoiceItems ??= new List<InvoiceItem>();

            InvoiceItems.Add(item);

            // Update totals
            TotalAmount += item.TotalPrice;
            TotalDiscount += item.Discount;
            TotalNet += item.TotalNet;
        }
        public void RemoveInvoiceItem(Guid invoiceItemId)
        {
            var item = InvoiceItems.FirstOrDefault(i => i.Id == invoiceItemId);
            if (item == null)
            {
                throw new InvalidOperationException("Invoice item not found.");
            }

            InvoiceItems.Remove(item);

            // Update totals
            TotalAmount -= item.TotalPrice;
            TotalDiscount -= item.Discount;
            TotalNet -= item.TotalNet;
        }
    }
}
