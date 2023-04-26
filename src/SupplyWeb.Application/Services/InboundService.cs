using SupplyWeb.Application.ViewModels;
using SupplyWeb.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Application.Services
{
    public class InboundService : IInboundService
    {
        private readonly IInboundRepository _inboundRepository;
        public InboundService(IInboundRepository inboundRepository)
        {
            _inboundRepository = inboundRepository;
        }

        public async Task<InboundViewModel> GetInbounds()
        {
            var vm = new InboundViewModel();
            vm.Inbounds = await _inboundRepository.GetInbounds();
            return vm;
        }
    }
}
