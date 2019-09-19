using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Agca.ECommerce.Core.Entities;

namespace Agca.ECommerce.Entities.Concrete
{
    public class Order : IEntity
    {
      
        public int Id { get; set; }
        public decimal TotalPrice { get; set;  }

        public List<OrderItem> OrderItems { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public Payment Payment { get; set; }

        public Shipment Shipment { get; set; }

    }
}
