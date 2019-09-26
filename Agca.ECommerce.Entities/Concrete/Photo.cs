using System;
using System.Collections.Generic;
using System.Text;

namespace Agca.ECommerce.Entities.Concrete
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
