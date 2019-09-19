using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Core.DataAccess;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.DataAccess.Abstract
{
    public interface IPaymentDal : IEntityRepository<Payment>
    {

    }
}
