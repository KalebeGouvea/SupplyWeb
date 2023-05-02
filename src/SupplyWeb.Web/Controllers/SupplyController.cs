using SupplyWeb.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<ActionResult> Index()
        {
            return View();
        }

        public async Task<ActionResult> Products()
        {
            var model = await _productService.GetProducts();
            return View(model);
        }
    }
}