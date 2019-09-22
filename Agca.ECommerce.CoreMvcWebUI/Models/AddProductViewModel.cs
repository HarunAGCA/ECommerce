using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.CoreMvcWebUI.Models
{
    public class AddProductViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
