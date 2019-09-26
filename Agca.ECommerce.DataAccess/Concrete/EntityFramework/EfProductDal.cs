using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Agca.ECommerce.Core.DataAccess.EntityFramework;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.DataAccess.Concrete.EntityFramework.Contexts;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ECommerceContext>, IProductDal
    {
        public List<Product> GetAllWithPhotos(Expression<Func<Product, bool>> filter = null)
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                return filter == null
                    ?
                    context.Set<Product>().Include(p => p.Photos).ToList()
                    :
                    context.Set<Product>().Include(p => p.Photos).Where(filter).ToList();
            }
        }

        public Product GetWithPhotos(int productId)
        {
            using(ECommerceContext context = new ECommerceContext())
            {
                return context.Set<Product>().Include(p=>p.Photos).FirstOrDefault(p => p.Id == productId);
            }
        }
    }
}
