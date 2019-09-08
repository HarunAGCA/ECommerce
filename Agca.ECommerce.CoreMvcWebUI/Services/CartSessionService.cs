using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Extensions;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Agca.ECommerce.CoreMvcWebUI.Services
{
    public class CartSessionService : ICartSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CartSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
            Cart cart = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart"); 
            if(cart == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                cart = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");        
            }
            return cart;
        }

        public void SetCart(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
