using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.CoreMvcWebUI.Services;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Agca.ECommerce.CoreMvcWebUI.Controllers
{

    public class ProductController : Controller
    {
        #region Fields
        private IProductService _productService;
        private ICustomerSessionService _customerSessionService;
        private const int PageSize = 10;
        #endregion

        #region Ctor
        public ProductController(
            IProductService productService,
            ICustomerSessionService customerSessionService
            )
        {
            _productService = productService;
            _customerSessionService = customerSessionService;
        }
        #endregion

        #region Methods
        public IActionResult List(int categoryId = 0, int page = 1)
        {
            

            List<Product> products = _productService.GetAllWithRelatedEntitiesByCategory(categoryId);
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

        public IActionResult Detail(int productId)
        {
            Product product = _productService.GetWithRelatedEntities(productId);
            if (product == null)
            {
                return RedirectToAction("List","Product");
            }
            ProductDetailViewModel productDetailViewModel = new ProductDetailViewModel();
            productDetailViewModel.Product = product;
            return View(productDetailViewModel);
        }
        #endregion
    }
}