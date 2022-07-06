using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Profile.Models;
using Profile.ViewModels;

namespace Profile.Controllers.AccountController
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            RegisterViewModel registerViewModel = new RegisterViewModel();
            return View(registerViewModel);
        }

        public IActionResult Login()
        { 
            LoginViewModel loginViewModel = new LoginViewModel();
            return View(loginViewModel);
        }


    }
}



//[HttpPost]
/*  public async Task<IActionResult> Login(LoginViewModel)
  {
      if (ModelState.IsValid)
      {
          return View(model);
          // Check if an email exist
          var user = await _userManager.FindByEmailAysnc(model.Email);
      }

      if (user == null)
      {
          ModelState.AddModelError("", "Email does not exist");
          return View(model);
      }
      var result = await _signManager.PasswordSignInAysnc(user, model.Password, false, false);
      if (!result.Succeeded)
      {

          ModelState.AddModelError("", "Email does not exist");
          return View(model);
      }


  }


   return RedirectToAction("Index", "Home")*/




