﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using invoiceTask.InvoiceItems.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace invoiceTask.InvoiceItems
{
    public interface IInvoiceItemAppService : ICrudAppService<InvoiceItemdto,Guid,PagedAndSortedResultRequestDto,CreateUpdateInvoiceItemDto>
    {
    }
}
