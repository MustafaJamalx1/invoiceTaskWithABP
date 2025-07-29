using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceTask.Invoices.Dto
{
    public class CreateUpdateInvoiceDto
    {
        [Required]
        public string CustomerName { get; set; }
        public DateTime InvoiceDate { get; set; }

    }
}
