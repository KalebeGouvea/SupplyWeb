﻿using SupplyWeb.Domain.Entities;
using SupplyWeb.Domain.Interfaces;
using SupplyWeb.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
