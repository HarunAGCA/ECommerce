using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Core.Entities;

namespace Agca.ECommerce.Entities.Concrete
{
    public class Shipment : IEntity
    {
        
        public int Id { get; set; }
        public string ReceiverTurkishIdNo { get; set; }
        public string ReceiverFirstName { get; set; }
        public string ReceiverLastName { get; set; }
        public string ReceiverPhoneNumber { get; set; }
        public string ReceiverEMail { get; set; }
        public string ReceiverAddress { get; set; }
        public DateTime TimeOfDelivery { get; set; }
        public DateTime TimeOfShipping { get; set; }

        public Order Order { get; set; }
        public int OrderId { get; set; }


    }
}
