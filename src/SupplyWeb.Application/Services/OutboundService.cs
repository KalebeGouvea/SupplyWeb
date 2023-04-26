using SupplyWeb.Application.ViewModels;
using SupplyWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Application.Services
{
    public class OutboundService : IOutboundService
    {
        private readonly IOutboundRepository _outboundRepository;
        public OutboundService(IOutboundRepository outboundRepository)
        {
            _outboundRepository = outboundRepository;
        }

        public async Task<OutboundViewModel> GetOutbounds()
        {
            var vm = new OutboundViewModel();
            vm.Outbounds = await _outboundRepository.GetOutbounds();
            return vm;
        }
    }
}
