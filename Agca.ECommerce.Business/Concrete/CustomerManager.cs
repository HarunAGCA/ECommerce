using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public Customer Get(int customerId)
        {
            return _customerDal.Get(c => c.Id == customerId);
        }
    }
}
