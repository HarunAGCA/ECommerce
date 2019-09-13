using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Abstract
{
    public interface IOrderService
    {
        Order Get(int orderId);
        void Add(Order order);
        

    }
}
