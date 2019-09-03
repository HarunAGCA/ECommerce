using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetByCategory(int categoryId);
        List<Product> GetAll();
        Product Get(int productId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
    }
}
