using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.Business.Concrete;
using Agca.ECommerce.CoreMvcWebUI.Middlewares;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.CoreMvcWebUI.Services;
using Agca.ECommerce.CoreMvcWebUI.ValidationRules.FluentValidation;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.DataAccess.Concrete.EntityFramework;
using Agca.ECommerce.DataAccess.Concrete.EntityFramework.Contexts;
using Agca.ECommerce.Entities.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Agca.ECommerce.CoreMvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddFluentValidation();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IOrderDal, EfOrderDal>();
            services.AddScoped<IOrderItemDal, EfOrderItemDal>();
            services.AddScoped<IOrderItemService, OrderItemManager>();
            services.AddScoped<IShipmentDal, EfShipmentDal>();
            services.AddScoped<IShipmentService, ShipmentManager>();
            services.AddScoped<IPaymentService, PaymentManager>();
            services.AddScoped<IPaymentDal, EfPaymentDal>();
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddSingleton<ICustomerSessionService, CustomerSessionService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IOrderViewModelSessionService, OrderViewModelSessionService>();
            services.AddTransient<IValidator<ShippingDetailsViewModel>, ShippingDetailsViewModelValidator>();
            services.AddTransient<IValidator<PaymentViewModel>, PaymentViewModelValidator>();
            services.AddSession();
            services.AddDistributedMemoryCache();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseNodeModules(env.ContentRootPath);
            app.UseSession();
            app.UseMvcWithDefaultRoute();
        }
    }
}
