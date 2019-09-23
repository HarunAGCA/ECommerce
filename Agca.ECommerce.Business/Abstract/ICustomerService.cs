using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        Customer Get(int customerId);
    }
}
