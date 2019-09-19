using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Extensions;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Microsoft.AspNetCore.Http;

namespace Agca.ECommerce.CoreMvcWebUI.Services
{
    public class OrderViewModelSessionService : IOrderViewModelSessionService
    {

        #region Fields
        private IHttpContextAccessor _httpContextAccessor;
        #endregion

        #region Ctor
        public OrderViewModelSessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        #endregion

        #region Methods
        public OrderViewModel GetOrderViewModel()
        {
            return _httpContextAccessor.HttpContext.Session.GetObject<OrderViewModel>("orderViewModel");
        }        

        public void SetOrderViewModel(OrderViewModel orderViewModel)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("orderViewModel", orderViewModel);
        }
        #endregion
    }
}
