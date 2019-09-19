using Agca.ECommerce.Core.Entities;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Entities
{
    public class OrderItem:IEntity
    {
               
        public int Id { get; set; }
        public int Quantity { get; set; }

        public Order Order { get; set; }
        public int OrderId { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }

    }
}