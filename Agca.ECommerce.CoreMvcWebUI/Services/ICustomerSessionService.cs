﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.CoreMvcWebUI.Services
{
    public interface ICustomerSessionService
    {
        Customer GetCustomer();

        void SetCustomer(Customer customer);
    }
}
