using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Agca.ECommerce.CoreMvcWebUI.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        #region Fields
        private IProductService _productService;
        private ICategoryService _categoryService;
        private const int PageSize = 10;

        #endregion

        #region Ctor
        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        #endregion

        #region Methods
        public IActionResult Index()
        {
            return RedirectToAction("ListProducts","Admin");
        }

        public IActionResult ListProducts(int categoryId = 0, int page = 1)
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

        public IActionResult AddProduct()
        {
            AddProductViewModel model = new AddProductViewModel
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductViewModel addProductViewModel)
        {

            var product = addProductViewModel.Product;

            if (!ModelState.IsValid)
            {

                TempData["message"] = "The product could not be added. Please check values that is entry.";
            }
            else
            {
                _productService.Add(product);
                TempData["message"] = String.Format("{0} has been successfully added to the products.", product.Name);

            }


            return RedirectToAction("AddProduct", "Admin");
        }

        public IActionResult UpdateProduct(int productId)
        {
            UpdateProductViewModel model = new UpdateProductViewModel
            {
                Product = _productService.Get(productId),
                Categories = _categoryService.GetAll()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductViewModel updateProductViewModel)
        {

            var product = updateProductViewModel.Product;

            if (!ModelState.IsValid)
            {
                TempData["message"] = "The product could not be updated. Please check values that is entry.";
                return RedirectToAction("UpdateProduct", "Admin",new { productId=product.Id});

            }

            _productService.Update(product);
            TempData["message"] = "The product has been successfully updated.";
            return RedirectToAction("ListProducts", "Admin");
        }

        public IActionResult DeleteProduct(int productId)
        {
            var productName = _productService.Get(productId).Name;
            _productService.Delete(productId);
            TempData["message"] = String.Format("{0} has been successfully deleted.", productName);
            return RedirectToAction("ListProducts", "Admin");
        }

        public IActionResult AddCategory()
        {
            AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel
            {
                Category = new Category()
            };
            return View(addCategoryViewModel);
        }

        [HttpPost]
        public IActionResult AddCategory(AddCategoryViewModel addCategoryViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(addCategoryViewModel);
            }
            Category category = new Category { Name = addCategoryViewModel.Category.Name };
            _categoryService.Add(category);
            TempData["message"] = "The category has been added.";
            return RedirectToAction("ListProducts", "Admin");
        }

        public IActionResult UpdateCategory(int categoryId)
        {
            UpdateCategoryViewModel model = new UpdateCategoryViewModel
            {

                Category = _categoryService.Get(categoryId)
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateCategory(UpdateCategoryViewModel updateCategoryViewModel)
        {

            var category = updateCategoryViewModel.Category;

            if (!ModelState.IsValid)
            {
                TempData["message"] = "The category could not be updated. Please check values that is entry.";
                return RedirectToAction("UpdateCategory", "Admin", new { categoryId = category.Id });

            }

            _categoryService.Update(category);
            TempData["message"] = "The category has been successfully updated.";
            return RedirectToAction("ListProducts", "Admin");
        }

        public IActionResult DeleteCategory(int categoryId)
        {
            var categoryName = _categoryService.Get(categoryId).Name;
            _categoryService.Delete(categoryId);
            TempData["message"] = String.Format("{0} has been successfully deleted.", categoryName);
            return RedirectToAction("ListProducts", "Admin");
        }

        #endregion
    }


}