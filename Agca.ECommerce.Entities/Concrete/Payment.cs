using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Core.Entities;

namespace Agca.ECommerce.Entities.Concrete
{
    public class Payment : IEntity
    {
       
        public int Id { get; set; }
        public string CreditCardNo { get; set; }
        public string CreditCardOwnerName { get; set; }
        public string CreditCardCVC { get; set; }
        public string CreditCardExpiryDate { get; set; }
        public decimal AmountOfPayment { get; set; }
        public DateTime DateOfPayment { get; set; }

        public Order Order { get; set; }
        public int OrderId { get; set; }




    }
}
