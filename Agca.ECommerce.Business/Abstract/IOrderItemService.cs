using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Entities;

namespace Agca.ECommerce.Business.Abstract
{
    public interface IOrderItemService
    {
        OrderItem Get(int id);
        void Add(OrderItem orderItem);
        List<OrderItem> GetListByOrderId(int orderId);

    }
}
