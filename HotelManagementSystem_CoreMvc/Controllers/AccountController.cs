using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using HotelManagementSystem_CoreMvc.Models;
using HotelManagementSystem_CoreMvc.Models.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagementSystem_CoreMvc.Controllers
{
    public class AccountController : Controller
    {
        SignInManager<ApplicationUser> _signInManager;
        UserManager<ApplicationUser> _userManager;
        RoleManager<ApplicationRole> _rollManager;
        ApplicationDbContext _applicationDbContext;

        public AccountController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> rollManager, ApplicationDbContext applicationDbContext, SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _rollManager = rollManager;
            _applicationDbContext = applicationDbContext;
        }


        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Email = registerModel.Email,
                    UserName = registerModel.UserName

                };
                IdentityResult result = await _userManager.CreateAsync(user, registerModel.ConfirmPassword);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password, string ReturnUrl)
        {
            var userAll = _userManager.Users.ToList();

            if (!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login");
            }
            try
            {
                var UserInstance = _userManager.Users.Where(w => w.Email == userName).FirstOrDefault();
                var userRole = _applicationDbContext.UserRoles.Where(w => w.UserId == UserInstance.Id).ToList();
                // var roleList = _applicationDbContext.Roles.Join(userRole, a => a.Id, b => b.RoleId, (a, b) => new { roleName = a.Name }).ToList();
                var roleList = _applicationDbContext.Roles.Join(userRole, a => a.Id, b => b.RoleId, (a, b) => new { roleName = a.Id }).ToList();

                IList<string> rolesList = new List<string>();
                foreach (var ro in roleList)
                {
                    rolesList.Add(ro.roleName.ToString());
                }

                bool yesFound = await _userManager.CheckPasswordAsync(UserInstance, password);

                if (!yesFound)
                {
                    return RedirectToAction("Index", "Home");
                }

                var customClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, UserInstance.UserName)
                };

                foreach (string s in rolesList)
                {
                    customClaims.Add(new Claim(ClaimTypes.Role, s));
                }

                var claimsIdentity = new ClaimsIdentity(customClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                await _signInManager.Context.SignInAsync(IdentityConstants.ApplicationScheme,
                    claimsPrincipal, new AuthenticationProperties { IsPersistent = false, RedirectUri = "/Home/Index" });
            }
            catch (Exception e)
            {
                var aa = e.Message;
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.Context.SignOutAsync();


            return RedirectToAction("Login");
        }

        [HttpGet]

        [ActionName("Logout")]
        public async Task<IActionResult> LogoutGet()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            await _signInManager.SignOutAsync();
            HttpContext.Response.Cookies.Delete("YourAppCookieName");

            return RedirectToAction("Login");
        }

        //public async Task<IActionResult> Profile( String name)
        //{
        //    var user = _userManager.FindByNameAsync(name);
        //    if (user == null)
        //        return RedirectToAction("UserManagement", _userManager.Users);

        //    var claims = await _userManager.GetClaimsAsync(user);
        //    var vm = new EditUserViewModel() { Id = user.Id, Email = user.Email, UserName = user.UserName };


        //    return View(vm);
        //}

        //public async Task<IActionResult> EditProfile(string id)
        //{
        //    var user = await _userManager.FindByIdAsync(id);

        //    if (user == null)
        //        return RedirectToAction("UserManagement", _userManager.Users);

        //    var claims = await _userManager.GetClaimsAsync(user);
        //    var vm = new EditUserViewModel() { Id = user.Id, Email = user.Email, UserName = user.UserName };

        //    return View(vm);
        //}

        //[HttpPost]
        //public async Task<IActionResult> EditProfile(EditUserViewModel editUserViewModel)
        //{
        //    var user = await _userManager.FindByIdAsync(editUserViewModel.Id);

        //    if (user != null)
        //    {
        //        user.Email = editUserViewModel.Email;
        //        user.UserName = editUserViewModel.UserName;

        //        var result = await _userManager.UpdateAsync(user);

        //        if (result.Succeeded)
        //            return RedirectToAction("Profile", "Account");

        //        ModelState.AddModelError("", "User not updated, something went wrong.");

        //        return RedirectToAction("Profile", "Account");
        //    }
        //    return RedirectToAction("Profile", "Account");
        //}

        //[HttpPost]
        //public async Task<IActionResult> DeleteProfile(string id)
        //{
        //    var user = await _userManager.FindByIdAsync(id);

        //    if (user != null)
        //    {
        //        IdentityResult result = await _userManager.DeleteAsync(user);
        //        if (result.Succeeded)
        //            return RedirectToAction("Index", "Home");
        //        else
        //            ModelState.AddModelError("", "Something went wrong while deleting this user.");
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "This user can't be found");
        //    }
        //    return RedirectToAction("Index","Home");
        //}



    }

}
