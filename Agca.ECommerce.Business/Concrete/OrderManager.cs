using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;


        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;

        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public Order Get(int orderId)
        {
            return _orderDal.Get(o => o.Id == orderId);
        }

        public List<Order> GetAllWithRelatedEntities()
        {
            return (List<Order>)_orderDal.GetWithAllNavigations();
        }

        public Order GetWithRelatedEntities(int orderId)
        {
            var orders = (List<Order>)_orderDal.GetWithAllNavigations(o => o.Id == orderId);
            Order order = orders.FirstOrDefault(o => o.Id == orderId);
            return order;
        }
    }
}
