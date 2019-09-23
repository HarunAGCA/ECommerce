using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Agca.ECommerce.Business.Abstract;
using Agca.ECommerce.Business.Concrete;
using Agca.ECommerce.CoreMvcWebUI.Entities;
using Agca.ECommerce.CoreMvcWebUI.Middlewares;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.CoreMvcWebUI.Services;
using Agca.ECommerce.CoreMvcWebUI.ValidationRules.FluentValidation;
using Agca.ECommerce.CoreMvcWebUI.ValidationRules.FluentValidation.Entities;
using Agca.ECommerce.DataAccess.Abstract;
using Agca.ECommerce.DataAccess.Concrete.EntityFramework;
using Agca.ECommerce.DataAccess.Concrete.EntityFramework.Contexts;
using Agca.ECommerce.Entities.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
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
            services.AddTransient<IValidator<AddProductViewModel>, AddProductViewModelValidator>();
            services.AddTransient<IValidator<UpdateProductViewModel>, UpdateProductViewModelValidator>();
            services.AddTransient<IValidator<LoginViewModel>, LoginViewModelValidator>();
            services.AddTransient<IValidator<RegisterViewModel>, RegisterViewModelValidator>();
            services.AddTransient<IValidator<AddCategoryViewModel>, AddCategoryViewModelValidator>();
            services.AddTransient<IValidator<Product>, ProductValidator>();
            services.AddTransient<IValidator<Shipment>, ShipmentValidator>();
            services.AddTransient<IValidator<Payment>, PaymentValidator>();
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddDbContext<CustomIdentityDbContext>(options => options.UseSqlServer("server=.;database=ECommerceIdentity;trusted_connection=true;"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>()
                .AddDefaultTokenProviders();


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
            app.UseAuthentication();
            app.UseStatusCodePages(async context =>
            {
                var response = context.HttpContext.Response;

                if (response.StatusCode == (int)HttpStatusCode.Unauthorized)
                {
                    response.Redirect("/Account/Login?statusCode=401");
                }
                else if (response.StatusCode == (int)HttpStatusCode.Forbidden)
                {
                    response.Redirect("/Account/Login&statusCode=403");
                }



            });
            app.UseSession();
            app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{Controller=Product}/{Action=List}/{Id?}");

        }
    }
}
