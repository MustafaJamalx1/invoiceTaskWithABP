using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace invoiceTask.Products.Dtos
{
    public class CreateUpdateProductDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        public int PartNo { get; set; }
    }
}
