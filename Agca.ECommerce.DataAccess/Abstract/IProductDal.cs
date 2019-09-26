using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Agca.ECommerce.Core.DataAccess;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        Product GetWithPhotos(int productId);
        List<Product> GetAllWithPhotos(Expression<Func<Product, bool>> filter = null);
    }
}
