using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Core.DataAccess;
using Agca.ECommerce.Entities;

namespace Agca.ECommerce.DataAccess.Abstract
{
    public interface IOrderItemDal:IEntityRepository<OrderItem>
    {
    }
}
