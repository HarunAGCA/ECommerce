using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Core.Entities;

namespace Agca.ECommerce.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }

    }
}
