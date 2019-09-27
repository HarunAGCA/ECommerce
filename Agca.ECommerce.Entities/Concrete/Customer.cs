using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Core.Entities;

namespace Agca.ECommerce.Entities.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }

        public List<Order> Orders { get; set; }     

    }
}
