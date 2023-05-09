using SupplyWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IList<Product>> GetProducts();
        Task AddProduct(Product product);
    }
}
