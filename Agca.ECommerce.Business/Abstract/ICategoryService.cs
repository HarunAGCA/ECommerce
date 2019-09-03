using System;
using System.Collections.Generic;
using System.Text;
using Agca.ECommerce.Entities.Concrete;

namespace Agca.ECommerce.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
