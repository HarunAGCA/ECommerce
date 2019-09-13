using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.CoreMvcWebUI.Extensions;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agca.ECommerce.CoreMvcWebUI.Controllers
{
    public class ShippingDetailsController : Controller
    {
        private IShippingDetailsService _shippingDetailsService;

        public ShippingDetailsController(IShippingDetailsService shippingDetailsService)
        {
            _shippingDetailsService = shippingDetailsService;
        }

        public IActionResult Create()
        {
            ShippingDetailsViewModel shippingDetailsViewModel = new ShippingDetailsViewModel();
            shippingDetailsViewModel.ShippingDetails = new ShippingDetails();
            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public IActionResult Create(ShippingDetailsViewModel shippingDetailsViewModel)

        {
            if (!ModelState.IsValid)
            {
                return View(shippingDetailsViewModel);
            }

            TempData.SetNonSerializableObject("shippingDetailsViewModel", shippingDetailsViewModel);
            return RedirectToAction("create","Order");

        }
    }
}