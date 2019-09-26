using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Core.Entities;

namespace Agca.ECommerce.Entities.Concrete
{
    public class Product : IEntity
    {
        public Product()
        {
            Photos = new List<Photo>();
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public List<Photo> Photos { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }


    }
}
