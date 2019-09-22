using System.Collections.Generic;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.CoreMvcWebUI.Models
{
    public class UpdateProductViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}