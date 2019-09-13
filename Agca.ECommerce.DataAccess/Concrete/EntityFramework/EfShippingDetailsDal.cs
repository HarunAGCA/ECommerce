﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Agca.ECommerce.Core.DataAccess.EntityFramework;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.DataAccess.Concrete.EntityFramework.Contexts;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.DataAccess.Concrete.EntityFramework
{
    public class EfShippingDetailsDal : EfEntityRepositoryBase<ShippingDetails, ECommerceContext>, IShippingDetailsDal
    {
        
    }
}
