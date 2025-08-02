using invoiceTask.Entites;
using invoiceTask.IRepos;
using invoiceTask.ProductDiscounts.Dtos;
using invoiceTask.ProductPricings.Dtos;
using invoiceTask.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace invoiceTask.Products
{
    public class ProductAppService :CrudAppService<Product,ProductDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateProductDto>, IProductAppService
    {
        private readonly IProductRepository _repository;
        private readonly IRepository<ProductDiscount, Guid> _productDiscountRepository;
        private readonly IRepository<ProductPricing, Guid> _productPricingRepository;

        public ProductAppService(IProductRepository repository, IRepository<ProductDiscount, Guid> productDiscountRepository, IRepository<ProductPricing, Guid> productPricingRepository) : base(repository)
        {
            _repository = repository;
            _productDiscountRepository = productDiscountRepository;
            _productPricingRepository = productPricingRepository;
        }

        public async Task<ProductDiscountDto> AddProductDiscountAsync(CreateUpdateProductDiscountDto input)
        {
            var product = await _repository.GetAsync(input.ProductId);
            if (product == null)
            {
                throw new Exception("Product not found");
            }
            var discount = new ProductDiscount(Guid.NewGuid() ,input.ProductId,input.Discount,input.StartDate,input.EndDate);
            product.AddDiscount(discount);
            await _repository.UpdateAsync(product);
            return ObjectMapper.Map<ProductDiscount, ProductDiscountDto>(discount);


        }

        public async Task<ProductPricingDto> AddProductPricingAsync(CreateUpdateProductPricingDto input)
        {
            var product = await _repository.GetAsync(input.ProductId);
            if (product == null)
            {
                throw new Exception("Product not found");
            }
            var pricing = new ProductPricing(Guid.NewGuid() ,input.ProductId, input.Price, input.StartDate, input.EndDate);
            product.AddPricing(pricing);
            await _repository.UpdateAsync(product); 
            return ObjectMapper.Map<ProductPricing, ProductPricingDto>(pricing);

        }

        public async Task<List<ProductDto>> GetAllWithDetailsAsyncDto()
        {
            var products = await _repository.GetAllWithDetailsAsync();
            return products.Select(product => ObjectMapper.Map<Product, ProductDto>(product)).ToList();
        }

        public async Task<ProductDiscountDto> RemoveProductDiscountAsync(Guid Id)
        {
            var discount = await _productDiscountRepository.GetAsync(Id);
            if (discount == null)
            {
                throw new Exception("Discount not found");
            }
            var product = await _repository.GetAsync(discount.ProductId);
            product.RemoveDiscount(Id);
            await _productDiscountRepository.DeleteAsync(Id);

            return ObjectMapper.Map<ProductDiscount, ProductDiscountDto>(discount);
        }

        public async Task<ProductPricingDto> RemoveProductPricingAsync(Guid Id)
        {
            var pricing = await _productPricingRepository.GetAsync(Id);
            if (pricing == null)
            {
                throw new Exception("pricing not found");
            }
            var product = await _repository.GetAsync(pricing.ProductId);
            product.RemovePricing(Id);
            await _productPricingRepository.DeleteAsync(Id);

            return ObjectMapper.Map<ProductPricing, ProductPricingDto>(pricing);
        }
    }
  
}
