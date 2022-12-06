using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication03.Models;
using WebApplication03.ViewModels;

namespace WebApplication03.Controllers
{
    // bör man vara inloggat
    //[Authorize]
    [Authorize(Roles = "Admin")]
    public class IdentityController : Controller
    {
        // för att hantera roller vi bör har till gång till Identity Tabler som ligger här 
        private readonly RoleManager<IdentityRole>  _roleManager;
        private readonly UserManager<ApplicationUser > _userManager;

        public IdentityController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager) // constructor för att skar instans 
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult ShowAllUsers()
        {
            return View(_userManager.Users);
        }

        public IActionResult ShowAllRoles()
        {
            return View(_roleManager.Roles);
        }

        // För att skapa Identity Behöver vi användas await och async task för funcktion
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRole(IdentityRole role)
        {
            await _roleManager.CreateAsync(role);
            return RedirectToAction("ShowAllRoles");
        }

        public async Task<IActionResult> AddRoleToUser(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            ViewBag.UserId = user.Id;
            ViewBag.Name = $"{user.Name} {user.EfterName}";
            ViewBag.Roles = new SelectList(_roleManager.Roles , "Name" , "Name" ); // i data basen vi valde att lägga roll på personer baserat på namn = Admin , User 
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRoleToUser(string userId , string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.AddToRoleAsync(user, roleName);   // if om rolen finns redan så skicka message//
            return RedirectToAction("ShowUserRoles" , new {id = userId}); // view som visar alla rolles till en användare
        }

        public async Task<IActionResult> ShowUserRoles(string id)
        {
            UserRolesVM vm = new UserRolesVM();
            var user = await _userManager.FindByIdAsync(id);
            var UsersAllRoles = new List<string>(await _userManager.GetRolesAsync(user)); // tar alla roles till den User och kasa dem till en lista
            vm.UserId = user.Id;
            vm.Name = $"{user.Name} {user.EfterName}";
            vm.Roles.AddRange(UsersAllRoles); // lägga till allt i VM lista

            return View(vm);
        }


        public async Task<IActionResult> DeleteRole(string id)
        {
            var roleToDlet = await _roleManager.FindByIdAsync(id);
            if(roleToDlet != null)
            {
                await _roleManager.DeleteAsync(roleToDlet);
                return RedirectToAction("ShowAllRoles");
            }
            ViewBag.Message = "Someting wrong happende , try again ! ";
            return RedirectToAction("ShowAllRoles");
        }

        public async Task<IActionResult> DeletUsersRole(string roleName , string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if(user != null)
            {
                await _userManager.RemoveFromRoleAsync(user, roleName);
                ViewBag.Message = $"Deletet Users Role {user.Name}";
                return RedirectToAction("ShowUserRoles", new { id = userId });
            }
            ViewBag.Message = "Someting wrong happende, try Again !";
            return RedirectToAction("ShowUserRoles", new { id = userId });
        }


        public async Task<IActionResult> DeleteUser(string id)
        {
            var userToDelet = await _userManager.FindByIdAsync(id);
            if(userToDelet != null)
            {
                await _userManager.DeleteAsync(userToDelet);
                return RedirectToAction("ShowAllUsers");
            }
            ViewBag.Message = "Someting wrong happende , try again ! ";
            return RedirectToAction("ShowAllUsers");
        }

    }
}
