﻿using SupplyWeb.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyWeb.Application.Services
{
    public interface IOutboundService
    {
        Task<OutboundViewModel> GetOutbounds();
    }
}
