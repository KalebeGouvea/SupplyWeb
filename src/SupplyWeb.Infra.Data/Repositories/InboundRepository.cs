using SupplyWeb.Domain.Entities;
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
    public class InboundRepository : IInboundRepository
    {
        private readonly AppDbContext _context;
        public InboundRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Inbound>> GetInbounds()
        {
            return await _context.Inbounds.ToListAsync();
        }
    }
}
