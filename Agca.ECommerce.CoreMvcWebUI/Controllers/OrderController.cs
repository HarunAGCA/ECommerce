using System.Linq;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.CoreMvcWebUI.Services;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agca.ECommerce.CoreMvcWebUI.Controllers
{
    public class OrderController : Controller
    {
        #region Fields
        private ICartSessionService _cartSessionService;
        private IOrderService _orderService;
        private IShipmentService _shipmentService;
        private IOrderItemService _orderItemService;
        private IOrderViewModelSessionService _orderViewModelSessionService;
        private IPaymentService _paymentService;
        #endregion

        #region Ctor
        public OrderController(
            ICartSessionService cartSessionService,
            IOrderService orderService,
            IShipmentService shipmentService,
            IOrderItemService orderItemService,
            IOrderViewModelSessionService orderViewModelSessionService,
            IPaymentService paymentService
            )
        {
            _cartSessionService = cartSessionService;
            _orderService = orderService;
            _shipmentService = shipmentService;
            _orderItemService = orderItemService;
            _orderViewModelSessionService = orderViewModelSessionService;
            _paymentService = paymentService;
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
            Order order = new Order { CustomerId = 1 , TotalPrice = orderViewModelSession.OrderItems.Sum(oi=>oi.Product.UnitPrice*oi.Quantity)};
            _orderService.Add(order);
            orderViewModelSession.Order = order;
            orderViewModelSession.Shipment.OrderId = order.Id;
            orderViewModelSession.Payment.OrderId = order.Id;
            orderViewModelSession.Payment.AmountOfPayment = order.TotalPrice;
            foreach (var orderItem in orderViewModelSession.OrderItems)
            {
                orderItem.OrderId = order.Id;
            }

            _shipmentService.Add(orderViewModelSession.Shipment);
            _paymentService.Add(orderViewModelSession.Payment);
            foreach (var orderItem in orderViewModelSession.OrderItems)
            {
                _orderItemService.Add(orderItem);
            }

            TempData["message"] = "Your order has been received. You can see order summary on below.";
            return View(orderViewModelSession);
        }

        public IActionResult Confirm()
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
            _cartSessionService.SetCart(new Cart());
            _orderViewModelSessionService.SetOrderViewModel(null);
            return RedirectToAction("list", "product");
        }
        #endregion
    }
}