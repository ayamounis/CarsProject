using CarsProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarsProject.Controllers
{
    public class AccountController : Controller
    {

        SignInManager<User> signInManager;
        UserManager<User> userManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserViewModel uservm)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = uservm.UserName,
                    
                    Email = uservm.Email
                };
                IdentityResult result = await userManager.CreateAsync(user, uservm.Password);
                if (result.Succeeded)
                {
                    //await userManager.AddToRoleAsync(user, "Admin"); // Add user to Customer role
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                return RedirectToAction("Login", "Account");
            }
            return View("Register", uservm);

        }

     

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginUserViewModel uservm)
        {
            if (ModelState.IsValid)
            {
                User user = await userManager.FindByNameAsync(uservm.UserName);
                if (user != null)
                {
                    bool found = await userManager.CheckPasswordAsync(user, uservm.password);
                    if (found)
                    {
                        List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName)
                };
                        await signInManager.SignInWithClaimsAsync(user, isPersistent: uservm.RememberMe, claims);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        // ✳️ كلمة السر غلط
                        ModelState.AddModelError(string.Empty, "Incorrect password.");
                    }
                }
                else
                {
                    // ✳️ المستخدم غير موجود
                    ModelState.AddModelError(string.Empty, "Username does not exist.");
                }
            }
            return View("Login", uservm);
        }

    }
}
