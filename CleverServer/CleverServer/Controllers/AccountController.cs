using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleverServer.Models;
using CleverServer.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CleverServer.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        public async Task<String> Register(RegisterViewModel model)
        {
            string err = "";
            if (ModelState.IsValid)
            {
                
                User user = new User { Email = model.Email, UserName = model.Email, Coin = 0, Point = 0 };
                // добавляем пользователя
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // установка куки
                    await signInManager.SignInAsync(user, false);
                    return "Index+Home";
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                        err += error.Description;
                    }
                }
            }
            return err;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}