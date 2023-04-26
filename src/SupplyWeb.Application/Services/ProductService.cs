using SupplyWeb.Application.ViewModels;
using SupplyWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductViewModel> GetProducts()
        {
            var vm = new ProductViewModel();
            vm.Products = await _productRepository.GetProducts();
            return vm;
        }
    }
}
