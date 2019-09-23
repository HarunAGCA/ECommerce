using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.CoreMvcWebUI.Services;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Agca.ECommerce.CoreMvcWebUI.Controllers
{
    [Authorize(Roles = "User")]
    public class PaymentController : Controller
    {
        #region Fields
        private IOrderViewModelSessionService _orderViewModelSessionService;
        #endregion

        #region Ctor
        public PaymentController(IOrderViewModelSessionService orderViewModelSessionService)
        {
            _orderViewModelSessionService = orderViewModelSessionService;
        }
        #endregion

        #region Methods
        public IActionResult CreditCard()
        {
            if (_orderViewModelSessionService.GetOrderViewModel() != null)
            {
                if (_orderViewModelSessionService.GetOrderViewModel().Shipment == null)
                {
                TempData["message"] = "You must provide the shipping information.";
                return RedirectToAction("Create", "ShippingDetails");
                }
            }
            else
            {
                TempData["message"] = "You must complete the shopping.";
                return RedirectToAction("ListCart", "Cart");
            }

            PaymentViewModel paymentViewModel = new PaymentViewModel();
            paymentViewModel.Payment = new Payment();
            return View(paymentViewModel);
        }

        [HttpPost]
        public IActionResult CreditCard(PaymentViewModel paymentViewModel)
        {
            if (_orderViewModelSessionService.GetOrderViewModel() != null)
            {
                if (_orderViewModelSessionService.GetOrderViewModel().Shipment == null)
                {
                    TempData["message"] = "You must provide the shipping information.";
                    return RedirectToAction("Create", "ShippingDetails");
                }
            }
            else
            {
                TempData["message"] = "You must complete the shopping.";
                return RedirectToAction("ListCart", "Cart");
            }

            if (!ModelState.IsValid)
            {
                return View(paymentViewModel);
            }

            var orderViewModelSession = _orderViewModelSessionService.GetOrderViewModel();

            var payment = new Payment
            {
                CreditCardNo = paymentViewModel.Payment.CreditCardNo,
                CreditCardOwnerName = paymentViewModel.Payment.CreditCardOwnerName,
                CreditCardExpiryDate = paymentViewModel.Payment.CreditCardExpiryDate,
                CreditCardCVC = paymentViewModel.Payment.CreditCardCVC,
                DateOfPayment = paymentViewModel.Payment.DateOfPayment,
                //AmountOfPayment = orderViewModelSession.Order.TotalPrice,
                //OrderId = orderViewModelSession.Order.Id              
            };

            orderViewModelSession.Payment = payment;
            _orderViewModelSessionService.SetOrderViewModel(orderViewModelSession);
            TempData.Add("message", "Your order has been received.");
            return RedirectToAction("Create", "Order");
        }
        #endregion
    }
}