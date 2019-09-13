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
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;
        private IShippingDetailsService _shippingDetailsService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService, IShippingDetailsService shippingDetailsService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
            _shippingDetailsService = shippingDetailsService;
        }

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
            return RedirectToAction("create", "ShippingDetails");
        }

        //[HttpPost]
        //public IActionResult Complete(ShippingDetailsViewModel shippingDetailsViewModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(shippingDetailsViewModel);
        //    }

        //    _shippingDetailsService.Add(shippingDetailsViewModel.ShippingDetails);
        //    TempData.Add("message", "Shipping informations was succesfull saved.");

        //    return RedirectToAction("create", "shippingDetails");
        //}

    }
}
