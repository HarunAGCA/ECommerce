using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.Entities;

namespace Agca.ECommerce.Business.Concrete
{
    public class OrderItemManager : IOrderItemService
    {
        #region Fields
        private IOrderItemDal _orderItemDal;
        #endregion

        #region Ctor
        public OrderItemManager(IOrderItemDal orderItemDal)
        {
            _orderItemDal = orderItemDal;
        }
        #endregion

        public void Add(OrderItem orderItem)
        {
            _orderItemDal.Add(orderItem);
        }

        public OrderItem Get(int id)
        {
            return _orderItemDal.Get(oi => oi.Id == id);
        }

        public List<OrderItem> GetListByOrderId(int orderId)
        {
            return _orderItemDal.GetList(oi => oi.OrderId == orderId);
        }
    }
}
