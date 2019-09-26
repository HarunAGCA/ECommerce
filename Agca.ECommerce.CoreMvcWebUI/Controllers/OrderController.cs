using System.Collections.Generic;
using System.Linq;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.CoreMvcWebUI.Services;
using Agca.ECommerce.Entities;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Agca.ECommerce.CoreMvcWebUI.Controllers
{
    [Authorize(Roles = "User")]
    public class OrderController : Controller
    {
        #region Fields
        private ICartSessionService _cartSessionService;
        private IOrderService _orderService;
        private IShipmentService _shipmentService;
        private IOrderItemService _orderItemService;
        private IOrderViewModelSessionService _orderViewModelSessionService;
        private IPaymentService _paymentService;
        private IProductService _productService;
        private ICustomerSessionService _customerSessionService;
        #endregion

        #region Ctor
        public OrderController(
            ICartSessionService cartSessionService,
            IOrderService orderService,
            IShipmentService shipmentService,
            IOrderItemService orderItemService,
            IOrderViewModelSessionService orderViewModelSessionService,
            IPaymentService paymentService,
            IProductService productService,
            ICustomerSessionService customerSessionService
            )
        {
            _cartSessionService = cartSessionService;
            _orderService = orderService;
            _shipmentService = shipmentService;
            _orderItemService = orderItemService;
            _orderViewModelSessionService = orderViewModelSessionService;
            _paymentService = paymentService;
            _productService = productService;
            _customerSessionService = customerSessionService;
        }
        #endregion

        #region Methods
        public IActionResult Create()
        {
            if (_orderViewModelSessionService.GetOrderViewModel() != null)
            {
                if (_orderViewModelSessionService.GetOrderViewModel().Payment == null)
                {
                    TempData["message"] = "You must provide the payment information.";
                    return RedirectToAction("CreditCard", "Payment");
                }
            }
            else
            {
                TempData["message"] = "You must complete the shopping.";
                return RedirectToAction("ListCart", "Cart");
            }

            var orderViewModelSession = _orderViewModelSessionService.GetOrderViewModel();

            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (var item in orderViewModelSession.OrderItems)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.Order = item.Order;
                orderItem.OrderId = item.OrderId;
                orderItem.Product = item.Product;
                orderItem.ProductId = item.ProductId;
                orderItem.Quantity = item.Quantity;

                orderItems.Add(orderItem);
            }

            Order order = new Order
            {
                CustomerId = _customerSessionService.GetCustomer().Id,
                Shipment = orderViewModelSession.Shipment,
                Payment = orderViewModelSession.Payment,
                OrderItems = orderItems,
                TotalPrice = orderViewModelSession.OrderItems.Sum(oi => oi.Product.UnitPrice * oi.Quantity)

            };

            orderViewModelSession.Order = order;
            
            foreach (var orderItem in order.OrderItems)
            {
                orderItem.Product = null;
            }
            
            _orderService.Add(order);

            foreach (var orderItem in orderViewModelSession.OrderItems)
            {               
                //Stock decrement
                var product = _productService.Get(orderItem.ProductId);
                product.UnitsInStock -= orderItem.Quantity;
                _productService.Update(product);

            }


            TempData["message"] = "Your order has been received. You can see order summary on below.";
            return View(orderViewModelSession);
        }

        public IActionResult Confirm()
        {
            _cartSessionService.SetCart(new Cart());
            _orderViewModelSessionService.SetOrderViewModel(null);
            return RedirectToAction("list", "product");
        }
        #endregion
    }
}