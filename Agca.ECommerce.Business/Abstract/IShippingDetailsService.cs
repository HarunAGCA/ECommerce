using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Abstract
{
   public interface IShippingDetailsService
    {
        void Add(ShippingDetails shippingDetails);

        ShippingDetails Get(int shippingDetailsId);
    }
}
