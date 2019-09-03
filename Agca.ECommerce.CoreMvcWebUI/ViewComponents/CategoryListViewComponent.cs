using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Agca.ECommerce.CoreMvcWebUI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            List<Category> categories = _categoryService.GetAll();

            CategoryListViewModel categoryListViewModel = new CategoryListViewModel();
            categoryListViewModel.Categories = categories;
            categoryListViewModel.CurrentCategoryId = Convert.ToInt32(HttpContext.Request.Query["categoryId"]);
            return View(categoryListViewModel);
        }
    }
}
