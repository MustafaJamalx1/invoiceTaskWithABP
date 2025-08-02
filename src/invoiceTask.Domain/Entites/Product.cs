using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace invoiceTask.Entites
{
    public class Product: FullAuditedAggregateRoot<Guid>
    {
        public string Name { get;  set; }
        public string Code { get;  set; }
        public int PartNo { get;  set; }

        public ICollection<ProductDiscount> Discounts { get; private set; } = [];
        public ICollection<ProductPricing> Pricings{ get; private set; } = [];


        public void AddDiscount(ProductDiscount discount)
        {

            Discounts.Add(discount);
        }
        public void AddPricing(ProductPricing pricing)
        {
        
            Pricings.Add(pricing);
        }
        public void RemoveDiscount(Guid discountId)
        { 
            if (Discounts == null) return;
            var discount = Discounts.FirstOrDefault(d => d.Id == discountId);
            if (discount != null)
            {
                Discounts.Remove(discount);
            }
        }

        public void RemovePricing(Guid pricingId)
        {
            if (Pricings == null) return;
            var pricing = Pricings.FirstOrDefault(p => p.Id == pricingId);
            if (pricing != null)
            {
                Pricings.Remove(pricing);
            }
        }
    }
}
