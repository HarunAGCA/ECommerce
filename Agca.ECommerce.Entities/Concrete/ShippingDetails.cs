using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Core.Entities;

namespace Agca.ECommerce.Entities.Concrete
{
    public class ShippingDetails:IEntity
    {
        public int Id { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerTurkishId { get; set; }
        public string ShippingAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
    }
}
