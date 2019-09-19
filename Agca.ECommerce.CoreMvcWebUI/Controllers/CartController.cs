using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.CoreMvcWebUI.Services;
using Agca.ECommerce.Entities;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agca.ECommerce.CoreMvcWebUI.Controllers
{
    public class CartController : Controller
    {
        #region Fields
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;
        private IOrderViewModelSessionService _orderViewModelSessionService;
        #endregion

        #region Ctor
        public CartController(
            ICartSessionService cartSessionService,
            ICartService cartService,
            IProductService productService,
            IOrderViewModelSessionService orderViewModelSessionService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
            _cartSessionService = cartSessionService;
            _orderViewModelSessionService = orderViewModelSessionService;
        }
        #endregion

        #region Methods
        public IActionResult AddToCart(int productId)
        {
            Product productToBeAdded = _productService.Get(productId);

            Cart cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart, productToBeAdded);

            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("{0} successfully was added to the cart.", productToBeAdded.Name));
            return RedirectToAction("list", "product");
        }

        public IActionResult ListCart()
        {
            Cart cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel();
            cartListViewModel.Cart = cart;

            return View(cartListViewModel);
        }

        public IActionResult Remove(int productId)
        {
            Cart cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("{0} was successfully removed from the cart.", _productService.Get(productId).Name));
            return RedirectToAction("ListCart", "Cart");
        }

        public IActionResult Complete()
        {
            var cart = _cartSessionService.GetCart();

            if(cart.CartLines.Count <= 0)
            {
                TempData["message"] = "There is no any product in your shopping cart.";
                return RedirectToAction("List", "Product");
            }

            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (var cartLine in cart.CartLines)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.ProductId = cartLine.Product.Id;
                orderItem.Product = cartLine.Product;
                orderItem.Quantity = cartLine.Quantity;
                orderItems.Add(orderItem);
            }


            OrderViewModel orderViewModel = new OrderViewModel();
            orderViewModel.OrderItems = orderItems;
            _orderViewModelSessionService.SetOrderViewModel(orderViewModel);
            return RedirectToAction("create", "ShippingDetails");
        }
        #endregion

    }
}
