using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace invoiceTask.Entites
{
    public class InvoiceItem: FullAuditedEntity<Guid>
    {
        public Guid InvoiceId { get; private set; }
        public Guid ProductId { get; private set; }
        public Product product { get; private set; }
        public int Quantity { get; private set; }
        public Guid ProductPricingId { get; private set; }
        public decimal Price { get; private set; }
        public decimal TotalPrice { get; private set; }
        public Guid ProductDiscountId { get; private set; }
        public decimal Discount {  get; private set; }
        public decimal TotalNet { get; private set; }
        public InvoiceItem(
            Guid invoiceId,
            Guid productId,
            int quantity,
            Guid productPricingId,
            decimal price,
            Guid productDiscountId,
            decimal discount)
        {
            Id = Guid.NewGuid();
            InvoiceId = invoiceId;
            ProductId = productId;
            Quantity = quantity;
            ProductPricingId = productPricingId;
            Price = price;
            TotalPrice = price*quantity;
            ProductDiscountId = productDiscountId;
            Discount = discount;
            TotalNet = TotalPrice-TotalPrice*(discount/100);
        }
        public void Update(
            Guid invoiceId,
            Guid productId,
            int quantity,
            Guid productPricingId,
            decimal price,
            Guid productDiscountId,
            decimal discount)
        {
            InvoiceId = invoiceId;
            ProductId = productId;
            Quantity = quantity;
            ProductPricingId = productPricingId;
            Price = price;
            TotalPrice = price * quantity;
            ProductDiscountId = productDiscountId;
            Discount = discount;
            TotalNet = TotalPrice - TotalPrice * (discount / 100);
        }

    }
}
