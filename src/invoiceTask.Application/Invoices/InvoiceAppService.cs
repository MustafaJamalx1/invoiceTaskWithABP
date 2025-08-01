using invoiceTask.Entites;
using invoiceTask.InvoiceItems.Dtos;
using invoiceTask.Invoices.Dto;
using invoiceTask.IRepos;
using invoiceTask.Products.Dtos;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;
using Volo.Abp.Timing;

namespace invoiceTask.Invoices
{
    public class InvoiceAppService : CrudAppService<Invoice, InvoiceDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateInvoiceDto>, IInvoiceAppService
    {
        private readonly IInvoiceRepositroy _repository;
        private readonly IProductRepository _productRepository;
        private readonly IRepository<InvoiceItem, Guid> _invoiceItemRepository;
        public InvoiceAppService(IInvoiceRepositroy repository, IProductRepository productRepository, IRepository<InvoiceItem, Guid> invoiceItemRepository) : base(repository)
        {
            _repository = repository;
            _invoiceItemRepository = invoiceItemRepository;
            _productRepository = productRepository;
        }

        public async Task<InvoiceItemDto> AddInvoiceItemAsync(CreateUpdateInvoiceItemDto input)
        {
            var invoice = await _repository.GetAsync(input.InvoiceId);
            if (invoice == null)
            {
                throw new Exception("Invoice not found.");
            }

            var product = await _productRepository.GetWithDetailsAsync(input.ProductId);
            if (product == null)
            {
                throw new Exception("Product not found.");
            }

            var today = DateTime.Now;

            var pricing = product.Pricings
                .FirstOrDefault();
            
            if (pricing == null)
            {
                throw new Exception("No active pricing found for the product.");
            }

            var discount = product.Discounts
                .FirstOrDefault();

            if (discount == null)
            {
                discount = new ProductDiscount(
                    input.ProductId,
                    0,
                    DateTime.Now,
                    DateTime.Now.AddYears(1)
                );
            }

            var invoiceItem = new InvoiceItem(
                input.InvoiceId,
                input.ProductId,
                input.Quantity,
                pricing.Id,
                pricing.Price,
                discount.Id,
                discount.Discount
            );

            invoice.AddInvoiceItem(invoiceItem);

            await _repository.UpdateAsync(invoice, true);

            var temp = ObjectMapper.Map<InvoiceItem, InvoiceItemDto>(invoiceItem);
            return temp;

        }

        public async Task<InvoiceItemDto> RemoveInvoiceItemAsync(Guid Id)
        {
            var invoiceItem = _invoiceItemRepository.GetAsync(Id).Result;
            if( invoiceItem == null)
            {
                throw new Exception("Invoice item not found.");
            }
            var invoice=await _repository.GetWithDetailsAsync(invoiceItem.InvoiceId);
            invoice.RemoveInvoiceItem(invoiceItem.Id);
            await _productRepository.DeleteAsync(Id);
            return ObjectMapper.Map<InvoiceItem, InvoiceItemDto>(invoiceItem);

        }

        public async Task<InvoiceItemDto> UpdateInvoiceItemAsync(Guid Id, CreateUpdateInvoiceItemDto input)
        {
            var invoiceItem = await _invoiceItemRepository.GetAsync(Id);
            if (invoiceItem == null)
            {
                throw new Exception("Invoice item not found.");
            }

            var invoice = await _repository.GetAsync(input.InvoiceId);
            if (invoice == null)
            {
                throw new Exception("Invoice not found.");
            }

            var product = await _productRepository.GetWithDetailsAsync(input.ProductId);
            if (product == null)
            {
                throw new Exception("Product not found.");
            }

            var today = DateTime.Now;

            var pricing = product.Pricings
                .Where(p => p.StartDate <= today)
                .Where(p => p.EndDate >= today)
                .OrderByDescending(p => p.StartDate)
                .FirstOrDefault();

            if (pricing == null)
            {
                throw new Exception("No active pricing found for the product.");
            }

            var discount = product.Discounts
                .Where(d => d.StartDate <= today)
                .Where(d => d.EndDate >= today)
                .OrderByDescending(d => d.StartDate)
                .FirstOrDefault();

            if (discount == null)
            {
                discount = new ProductDiscount(
                    input.ProductId,
                    0,
                    DateTime.Now,
                    DateTime.Now.AddYears(1)
                );
            }

            invoiceItem.Update(
                input.InvoiceId,
                input.ProductId,
                input.Quantity,
                pricing.Id,
                pricing.Price,
                discount.Id,
                discount.Discount
            );

            await _invoiceItemRepository.UpdateAsync(invoiceItem);
            await _repository.UpdateAsync(invoice);
            return ObjectMapper.Map<InvoiceItem, InvoiceItemDto>(invoiceItem);
        }
        public async Task<List<InvoiceDto>> GetListWithDetailsAsync()
        {
            var queryable = await _repository.WithDetailsAsync(x => x.InvoiceItems);
            return queryable.Select(product => ObjectMapper.Map<Invoice, InvoiceDto>(product)).ToList();
        }
    }
}
