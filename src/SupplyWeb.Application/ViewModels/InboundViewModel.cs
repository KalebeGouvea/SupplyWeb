using SupplyWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Application.ViewModels
{
    public class InboundViewModel
    {
        public IList<Inbound> Inbounds { get; set; }
    }
}
