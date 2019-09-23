using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Agca.ECommerce.CoreMvcWebUI.ViewComponents
{
    public class UserSummaryViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            UserSummaryViewModel userSummaryViewModel = new UserSummaryViewModel
            {
                UserName = HttpContext.User.Identity.Name
            };

            return View(userSummaryViewModel);
        }
    }
}