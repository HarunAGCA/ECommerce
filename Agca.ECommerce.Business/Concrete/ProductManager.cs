using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { Id = productId });
        }

        public Product Get(int productId)
        {
            return _productDal.Get(p => p.Id == productId);
        }


        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetAllWithPhotos()
        {
            return _productDal.GetAllWithPhotos();
        }

        public List<Product> GetAllWithRelatedEntities()
        {
            return (List<Product>)_productDal.GetWithAllNavigations();
        }

        public List<Product> GetAllWithRelatedEntitiesByCategory(int categoryId)
        {
            if (categoryId == 0)
            {
                return (List<Product>)_productDal.GetWithAllNavigations();
            }
            else
            {
                return (List<Product>)_productDal.GetWithAllNavigations(p => p.CategoryId == categoryId);
            }
            
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.Category.Id == categoryId || categoryId == 0);
        }

        public Product GetWithPhotos(int productId)
        {
            return _productDal.GetWithPhotos(productId);
        }

        public Product GetWithRelatedEntities(int productId)
        {
           var products = (List<Product>) _productDal.GetWithAllNavigations(p=>p.Id == productId);
            Product product = products.Find(p => p.Id == productId);
            return product;
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
