using invoiceTask.Entites;
using invoiceTask.InvoiceItems.Dtos;
using invoiceTask.Invoices.Dto;
using invoiceTask.IRepos;
using JetBrains.Annotations;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace invoiceTask.Invoices
{
    public class InvoiceAppService : CrudAppService<Invoice, InvoiceDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateInvoiceDto>, IInvoiceAppService
    {
        private readonly IInvoiceItemRepository _invoiceItemRepository;
        private readonly IInvoiceRepositroy _repository;
        public InvoiceAppService(IInvoiceRepositroy repository, IInvoiceItemRepository invoiceItemRepository) : base(repository)
        {
            _invoiceItemRepository = invoiceItemRepository;
            _repository = repository;
        }

        public override async Task<InvoiceDto> UpdateAsync(Guid id, CreateUpdateInvoiceDto input)
        {
            var invoice = await _repository.GetAsync(id);

            invoice.CustomerName = input.CustomerName;
            invoice.InvoiceDate = input.InvoiceDate;

            var invoiceItems = await _invoiceItemRepository.GetListAsync(x => x.InvoiceId == invoice.Id);
            invoice.InvoiceItems = invoiceItems;

            invoice.TotalAmount = invoiceItems.Sum(x => x.TotalPrice);
            invoice.TotalNet = invoiceItems.Sum(x => x.TotalNet);
            invoice.TotalDiscount = invoice.TotalAmount - invoice.TotalNet;

            await _repository.UpdateAsync(invoice);

            return ObjectMapper.Map<Invoice, InvoiceDto>(invoice); // Map the updated Invoice entity to InvoiceDto
        }
    }
}
