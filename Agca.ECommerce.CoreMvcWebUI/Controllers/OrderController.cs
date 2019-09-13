using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Extensions;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.CoreMvcWebUI.Services;
using Agca.ECommerce.Entities;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agca.ECommerce.CoreMvcWebUI.Controllers
{
    public class OrderController : Controller
    {
        private ICartSessionService _cartSessionService;
        private static ShippingDetailsViewModel shippingDetailsViewModel;

        public OrderController(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {

            if(TempData.GetNonSerializableObject<ShippingDetailsViewModel>("shippingDetailsViewModel") != null)
            {
                shippingDetailsViewModel = TempData.GetNonSerializableObject<ShippingDetailsViewModel>("shippingDetailsViewModel");
            }
            else
            {
                TempData["message"] = "Shipping Informations was not received. Please try again.";
                return RedirectToAction("create", "ShippingDetails");
            }
            
            var orderItems = new List<OrderItem>();

            foreach (var item in _cartSessionService.GetCart().CartLines)
            {
                var orderItem = new OrderItem();
                orderItem.Product = item.Product;
                orderItem.ProductQuantity = item.Quantity;
                orderItems.Add(orderItem);
            }

            OrderViewModel orderViewModel = new OrderViewModel();
            orderViewModel.ShippingDetails = shippingDetailsViewModel.ShippingDetails;
            orderViewModel.OrderItems = orderItems;
            TempData.Keep();
            return View(orderViewModel);
        }
    }
}