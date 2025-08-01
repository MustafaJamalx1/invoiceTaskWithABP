using invoiceTask.InvoiceItems.Dtos;
using invoiceTask.Invoices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace invoiceTask.Invoices
{
    public interface IInvoiceAppService : ICrudAppService<InvoiceDto, Guid, PagedAndSortedResultRequestDto,CreateUpdateInvoiceDto>
    {
        Task<InvoiceItemDto> AddInvoiceItemAsync(CreateUpdateInvoiceItemDto input);
        Task<InvoiceItemDto> UpdateInvoiceItemAsync(Guid Id, CreateUpdateInvoiceItemDto input);
        Task<InvoiceItemDto> RemoveInvoiceItemAsync(Guid Id);
        Task<List<InvoiceDto>> GetListWithDetailsAsync();


    }
}
