using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Models;

namespace Agca.ECommerce.CoreMvcWebUI.Services
{
    public interface IOrderViewModelSessionService
    {
        OrderViewModel GetOrderViewModel();
        void SetOrderViewModel(OrderViewModel orderViewModel);
    }
}
