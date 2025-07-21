using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace invoiceTask.ProductDiscounts.Dtos
{
    public class CreateUpdateProductDiscountDto
    {
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public decimal Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
