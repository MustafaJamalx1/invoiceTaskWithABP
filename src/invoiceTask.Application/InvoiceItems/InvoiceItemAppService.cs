using System;
using System.Threading.Tasks;
using invoiceTask.Entites;
using invoiceTask.InvoiceItems.Dtos;
using invoiceTask.IRepos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace invoiceTask.InvoiceItems
{
    public class InvoiceItemAppService : CrudAppService<InvoiceItem, InvoiceItemdto, Guid, PagedAndSortedResultRequestDto, CreateUpdateInvoiceItemDto>, IInvoiceItemAppService
    {
        private readonly IInvoiceItemRepository _invoiceItemRepository;
        public InvoiceItemAppService(IInvoiceItemRepository repository) : base(repository)
        {

                _invoiceItemRepository = repository;
        }

        public override Task<InvoiceItemdto> CreateAsync(CreateUpdateInvoiceItemDto input)
        {
            var pricing= _invoiceItemRepository.GetActivePricing(input.ProductId);
            var discount = _invoiceItemRepository.GetActiveDiscount(input.ProductId);
            //InvoiceItemdto invoiceItem = new InvoiceItemdto({
            //     ProductId = input.ProductId,
            //    Price=pricing.Price,
            //}
            //    );
            



            return base.CreateAsync(input);
        }
    }

}
