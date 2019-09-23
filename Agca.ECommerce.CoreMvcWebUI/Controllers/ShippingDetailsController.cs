using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.CoreMvcWebUI.Extensions;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.CoreMvcWebUI.Services;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Agca.ECommerce.CoreMvcWebUI.Controllers
{
    [Authorize(Roles = "User")]
    public class ShippingDetailsController : Controller
    {
        #region Fiels
        private IOrderViewModelSessionService _orderViewModelSessionService;
        private ICartSessionService _cartSessionService;
        #endregion

        #region Ctor
        public ShippingDetailsController(
            IOrderViewModelSessionService orderViewModelSessionService,
            ICartSessionService cartSessionService
            )
        {
            _orderViewModelSessionService = orderViewModelSessionService;
            _cartSessionService = cartSessionService; 
        }
        #endregion

        #region Methods
        public IActionResult Create()
        {
            
            if (_orderViewModelSessionService.GetOrderViewModel() == null)
            {
                if (_cartSessionService.GetCart().CartLines.Count <= 0)
                {
                    TempData["message"] = "There is no any product in your cart.";
                    return RedirectToAction("List", "Product");
                }

                TempData["message"] = "You must complete the shipping.";
                return RedirectToAction("List", "Cart");
            }
            ShippingDetailsViewModel shippingDetailsViewModel = new ShippingDetailsViewModel();
            shippingDetailsViewModel.Shipment = new Shipment();
            return View(shippingDetailsViewModel);
        }

        [HttpPost]
        public IActionResult Create(ShippingDetailsViewModel shippingDetailsViewModel)
        {
            if (_orderViewModelSessionService.GetOrderViewModel() == null)
            {
                if (_orderViewModelSessionService.GetOrderViewModel().OrderItems.Count <= 0)
                {
                    TempData["message"] = "There is no any product in your cart.";
                    return RedirectToAction("List", "Product");
                }

                TempData["message"] = "You must complete the shipping.";
                return RedirectToAction("List", "Cart");
            }

            if (!ModelState.IsValid)
            {
                return View(shippingDetailsViewModel);
            }
            var orderViewModelSession = _orderViewModelSessionService.GetOrderViewModel();

            var shipment = new Shipment
            {
                ReceiverTurkishIdNo = shippingDetailsViewModel.Shipment.ReceiverTurkishIdNo,
                ReceiverFirstName = shippingDetailsViewModel.Shipment.ReceiverFirstName,
                ReceiverLastName = shippingDetailsViewModel.Shipment.ReceiverLastName,
                ReceiverPhoneNumber = shippingDetailsViewModel.Shipment.ReceiverPhoneNumber,
                ReceiverEMail = shippingDetailsViewModel.Shipment.ReceiverEMail,
                ReceiverAddress = shippingDetailsViewModel.Shipment.ReceiverAddress,
                TimeOfDelivery = shippingDetailsViewModel.Shipment.TimeOfDelivery,
                TimeOfShipping = shippingDetailsViewModel.Shipment.TimeOfShipping,
            };
            orderViewModelSession.Shipment = shipment;
            _orderViewModelSessionService.SetOrderViewModel(orderViewModelSession);

            return RedirectToAction("CreditCard", "Payment");

        }
        #endregion
    }
}