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
        List<Product> GetAllWithRelatedEntities();
        Product GetWithRelatedEntities(int productId);

        List<Product> GetAllWithRelatedEntitiesByCategory(int categoryId);

        Product GetWithPhotos(int productId);
        List<Product> GetAllWithPhotos();


        Product Get(int productId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
    }
}
