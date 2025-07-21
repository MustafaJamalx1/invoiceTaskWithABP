using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceTask.ProductPricings.Dtos
{
    public class CreateUpdateProductPricingDto
    {
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
