using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Extensions;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Agca.ECommerce.CoreMvcWebUI.Services
{
    public class CustomerSessionService : ICustomerSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CustomerSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Customer GetCustomer()
        {
            Customer customer = _httpContextAccessor.HttpContext.Session.GetObject<Customer>("customer");
            return customer;
        }

        public void SetCustomer(Customer customer)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("customer", customer);
        }
    }
}
