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
        public string Name { get; set; }
        public string Code { get; set; }
        public int PartNo { get; set; }
        
        public ICollection<ProductDiscount> Discounts { get; set; }=new List<ProductDiscount>();
        public ICollection<ProductPricing> Pricings{ get; set; } = new List<ProductPricing>();

    }
}
