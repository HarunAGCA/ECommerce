using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(int categoryId)
        {
            _categoryDal.Delete(new Category { Id = categoryId });
        }

        public Category Get(int categoryId)
        {
            return _categoryDal.Get(c => c.Id == categoryId);
        }

        public List<Category> GetAll()
        {
           return _categoryDal.GetList(null);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
