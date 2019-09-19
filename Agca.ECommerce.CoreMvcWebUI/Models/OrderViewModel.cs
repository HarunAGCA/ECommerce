using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Entities;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.CoreMvcWebUI.Models
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public Shipment Shipment { get; set; }
        public Payment Payment { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}
