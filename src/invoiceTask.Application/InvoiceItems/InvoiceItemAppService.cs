using System;
using System.Threading.Tasks;
using invoiceTask.Entites;
using invoiceTask.InvoiceItems.Dtos;
using invoiceTask.IRepos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace invoiceTask.InvoiceItems
{
    public class InvoiceItemAppService : CrudAppService<InvoiceItem, InvoiceItemDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateInvoiceItemDto>, IInvoiceItemAppService
    {
        private readonly IInvoiceItemRepository _invoiceItemRepository;
        private readonly IProductPricingRepository _productPricingRepository;
        private readonly IProductDiscountRepository _productDiscountRepository;
        public InvoiceItemAppService(IInvoiceItemRepository repository, IProductPricingRepository productPricingRepository, IProductDiscountRepository productDiscountRepository) : base(repository)
        {

            _invoiceItemRepository = repository;
            _productPricingRepository = productPricingRepository;
            _productDiscountRepository = productDiscountRepository;
        }

        public override async Task<InvoiceItemDto> CreateAsync(CreateUpdateInvoiceItemDto input)

        {
            var discount = await _productDiscountRepository.GetActiveDiscountAsync(input.ProductId);
            var pricing = await _productPricingRepository.GetActivePricingAsync(input.ProductId);

            var invoiceItem = ObjectMapper.Map<CreateUpdateInvoiceItemDto, InvoiceItem>(input);
            invoiceItem.ProductPricingId = pricing.Id;
            invoiceItem.Price = pricing.Price;
            invoiceItem.Discount = discount?.Discount ?? 0;
            invoiceItem.ProductDiscountId = discount?.Id ?? Guid.Empty;
            invoiceItem.TotalPrice = invoiceItem.Price * invoiceItem.Quantity;
            invoiceItem.TotalNet = invoiceItem.TotalPrice - (invoiceItem.TotalPrice * (invoiceItem.Discount / 100));

            await _invoiceItemRepository.InsertAsync(invoiceItem);

            return ObjectMapper.Map<InvoiceItem, InvoiceItemDto>(invoiceItem);

        }

    }

}
