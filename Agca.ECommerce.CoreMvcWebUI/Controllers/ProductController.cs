using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agca.ECommerce.CoreMvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private const int PageSize = 10;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int categoryId = 0, int page = 1)
          {
            List<Product> products = _productService.GetByCategory(categoryId);
            ProductListViewModel productListViewModel = new ProductListViewModel
            {
                Products = products.Skip(PageSize * (page - 1)).Take(PageSize).ToList(),
                PageSize = PageSize,
                PageCount = Convert.ToInt32(Math.Ceiling(products.Count / (double)PageSize)),
                CurrentCategoryId = categoryId,
                CurrentPage = page,
            };

            return View(productListViewModel);
        }
    }
}