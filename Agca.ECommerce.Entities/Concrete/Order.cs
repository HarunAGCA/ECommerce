using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Core.Entities;

namespace Agca.ECommerce.Entities.Concrete
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public ShippingDetails ShippingDetails { get; set; }
    }
}
