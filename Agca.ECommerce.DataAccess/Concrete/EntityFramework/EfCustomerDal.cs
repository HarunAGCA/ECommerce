using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Core.DataAccess.EntityFramework;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.DataAccess.Concrete.EntityFramework.Contexts;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer,ECommerceContext>,ICustomerDal
    {
    }
}
