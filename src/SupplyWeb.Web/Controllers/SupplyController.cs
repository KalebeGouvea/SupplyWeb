using SupplyWeb.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SupplyWeb.Web.Controllers
{
    public class SupplyController : Controller
    {
        private readonly IProductService _productService;
        private readonly IInboundService _inboundService;
        private readonly IOutboundService _outboundService;
        public SupplyController(IProductService productService, IInboundService inboundService, IOutboundService outboundService)
        {
            _productService = productService;
            _inboundService = inboundService;
            _outboundService = outboundService;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}