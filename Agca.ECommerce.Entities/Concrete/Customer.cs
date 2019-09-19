using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Core.Entities;

namespace Agca.ECommerce.Entities.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string TurkishIdNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }

        public List<Order> Orders { get; set; }     

    }
}
