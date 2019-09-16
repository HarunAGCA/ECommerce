using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Business.Abstract;
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
        private IOrderService _orderService;

        public OrderController(ICartSessionService cartSessionService, IOrderService orderService)
        {
            _cartSessionService = cartSessionService;
            _orderService = orderService;
        }

       

        [HttpPost]
        public IActionResult Create(ShippingDetailsViewModel shippingDetailsViewModel)
        {

            if (!ModelState.IsValid)
            {
                return View("../ShippingDetails/create", shippingDetailsViewModel);
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
            Order order = new Order();
            order.OrderItems = orderViewModel.OrderItems;
            order.ShippingDetails = orderViewModel.ShippingDetails;
            _orderService.Add(order);
            TempData["message"] = "Please confirm the order details to give order.";
            return View(orderViewModel);
        }
        
        public IActionResult Confirm()
        {
            TempData["message"] = "Your order has been received.";
            _cartSessionService.SetCart(new Cart());
            return RedirectToAction("list","product");
        }


    }
}