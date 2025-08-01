using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace invoiceTask.Entites
{
    public class ProductDiscount: FullAuditedEntity<Guid>
    {
        public Guid ProductId { get; private set; }
        public decimal Discount { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public ProductDiscount(Guid productId, decimal discount, DateTime startDate, DateTime endDate)
        {
            Id = Guid.NewGuid();
            ProductId = productId;
            Discount = discount;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
