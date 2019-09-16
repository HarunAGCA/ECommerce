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
        public List<OrderItem> OrderItems { get; set; }
        public ShippingDetails ShippingDetails { get; set; }
        public decimal TotalPrice { get { return OrderItems.Sum(o => o.Product.UnitPrice * o.ProductQuantity); } }
        
    }
}
