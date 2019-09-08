using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Abstract
{
   public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int ProductId);
        List<CartLine> List(Cart cart);
    }
}
