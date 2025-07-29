using AutoMapper;
using invoiceTask.Entites;
using invoiceTask.InvoiceItems.Dtos;
using invoiceTask.Invoices.Dto;
using invoiceTask.ProductDiscounts.Dtos;
using invoiceTask.ProductPricings.Dtos;
using invoiceTask.Products;
using invoiceTask.Products.Dtos;

namespace invoiceTask;

public class invoiceTaskApplicationAutoMapperProfile : Profile
{
    public invoiceTaskApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Product, ProductDto>();
        CreateMap<CreateUpdateProductDto, Product>();
        CreateMap<ProductDiscount, ProductDiscountDto>();
        CreateMap<CreateUpdateProductDiscountDto, ProductDiscount>();
        CreateMap<ProductPricing, ProductPricingDto>();
        CreateMap<CreateUpdateProductPricingDto, ProductPricing>();
        CreateMap<InvoiceItem, InvoiceItemDto>();
        CreateMap<CreateUpdateInvoiceItemDto, InvoiceItem>();
        CreateMap<Invoice, InvoiceDto>();
        CreateMap<CreateUpdateInvoiceDto, Invoice>();

    }
}
