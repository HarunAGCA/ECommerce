using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Abstract
{
    public interface IPaymentService
    {
        void Add(Payment payment);
        Payment Get(int id);

        
    }
}
