using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.CoreMvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Agca.ECommerce.CoreMvcWebUI.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {

        private ICartSessionService _cartSessionService;

        public CartSummaryViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            CartSummaryViewModel cartSummaryViewModel = new CartSummaryViewModel();
            cartSummaryViewModel.Cart = _cartSessionService.GetCart();
            return View(cartSummaryViewModel);
        }
    }
}
