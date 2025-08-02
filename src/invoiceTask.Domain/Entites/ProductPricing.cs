using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace invoiceTask.Entites
{
    public class ProductPricing: FullAuditedEntity<Guid>
    {

        public Guid ProductId { get; private set; }
        public decimal Price { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public ProductPricing(Guid id,Guid productId, decimal price, DateTime startDate, DateTime endDate)
        {
            Id = id; 
            ProductId = productId;
            Price = price;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
