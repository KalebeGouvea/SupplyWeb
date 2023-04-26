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
    public class OutboundRepository : IOutboundRepository
    {
        private readonly AppDbContext _context;
        public OutboundRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Outbound>> GetOutbounds()
        {
            return await _context.Outbounds.ToListAsync();
        }
    }
}
