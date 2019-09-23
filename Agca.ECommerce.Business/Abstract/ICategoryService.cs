using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        Category Get(int categoryId);
        void Delete(int categoryId);
    }
}
