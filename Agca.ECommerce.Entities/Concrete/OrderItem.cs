using Agca.ECommerce.Core.Entities;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Entities
{
    public class OrderItem:IEntity
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductQuantity { get; set; }

    }
}