using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Entities;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

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

        #region Methods
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                CustomIdentityUser customIdentityUser = new CustomIdentityUser
                {
                    Email = registerViewModel.EMail,
                    UserName = registerViewModel.UserName,
                };

                IdentityResult identityResult = _userManager.CreateAsync(customIdentityUser, registerViewModel.Password).Result;

                if (identityResult.Succeeded)
                {

                    CustomIdentityRole customIdentityRole;

                    if (!_roleManager.RoleExistsAsync("Admin").Result)
                    {
                        customIdentityRole = new CustomIdentityRole { Name = "Admin" };
                        IdentityResult roleIdentityResult = _roleManager.CreateAsync(customIdentityRole).Result;
                        if (!roleIdentityResult.Succeeded)
                        {
                            ModelState.AddModelError("", "We can not add the role!");
                            var errorMessage = CheckError(roleIdentityResult);
                            TempData["registerMessage"] = errorMessage;
                            return View(registerViewModel);
                        }
                    }
                    else
                    {
                        customIdentityRole = new CustomIdentityRole { Name = "User" };
                        IdentityResult roleIdentityResult = _roleManager.CreateAsync(customIdentityRole).Result;
                        if (!roleIdentityResult.Succeeded)
                        {
                            ModelState.AddModelError("", "We can not add the role!");
                            var errorMessage = CheckError(roleIdentityResult);
                            TempData["registerMessage"] = errorMessage;
                            return View(registerViewModel);
                        }
                    }

                    _userManager.AddToRoleAsync(customIdentityUser, customIdentityRole.Name).Wait();
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    string errorMessage = CheckError(identityResult);
                    TempData["registerMessage"] = errorMessage;
                }
            }

            return View(registerViewModel);
        }

        public IActionResult Login(string returnUrl)

        {           
            if (!String.IsNullOrEmpty(returnUrl))
            {          
                    TempData["loginForbiddenMessage"] = "You do not have permission to perfom this action.";              
            }
           
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                SignInResult result = _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, loginViewModel.RememberMe, false).Result;
                if (result.Succeeded)
                {
                    CustomIdentityUser user = await _userManager.FindByNameAsync(loginViewModel.UserName);

                    if (_userManager.IsInRoleAsync(user, "Admin").Result)
                    {
                        return RedirectToAction("index", "Admin");
                    }
                    else if (_userManager.IsInRoleAsync(user, "User").Result)
                    {
                        return RedirectToAction("List", "Product");
                    }
                }
                else
                {
                    
                }

                ModelState.AddModelError("", "Invalid Login");
            }
            return View(loginViewModel);
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Login","Account");
        }

        #endregion


        private string CheckError(IdentityResult result)
        {
            string errorString = "";
            foreach (var error in result.Errors)
            {
                errorString += error.Description + "\n";
            }
            return errorString;
        }

    }
}