using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CarsProject.Models;
using Microsoft.AspNetCore.Identity;

namespace CarsProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> roleManager;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager; 
        }
        public IActionResult Create()
        {
            return View("Create");
        }


        [HttpPost]
        public async Task<IActionResult> Create(RoleViewModel rolevm)
        {
            if (ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole() { Name = rolevm.RoleName };

                IdentityResult result = await roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return View("Create");
                }

                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

            }
            return View("Create", rolevm);

        }
    }
}
