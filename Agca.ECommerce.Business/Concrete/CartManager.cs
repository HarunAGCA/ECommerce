using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.Id == product.Id);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }

            cart.CartLines.Add(new CartLine {Product = product, Quantity = 1}); 
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int ProductId)   
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.Id == ProductId));
        }
    }
}
