using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Agca.ECommerce.CoreMvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        #region Fiels
        UserManager<CustomIdentityUser> _userManager;
        RoleManager<CustomIdentityRole> _roleManager;
        SignInManager<CustomIdentityUser> _signInManager;
        #endregion

        #region Ctor
        public AccountController(
            UserManager<CustomIdentityUser> userManager,
            RoleManager<CustomIdentityRole> roleManager,
            SignInManager<CustomIdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        #endregion



    }
}