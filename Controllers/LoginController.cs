using HastaneMvc.Models.Dbcontext;
using HastaneMvc.Models.Sınıflar;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HastaneMvc.Controllers
{
    public class LoginController : Controller
    {
        Dbcontext dbbaglan = new Dbcontext();
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Admin admin)
        {
            var giris = dbbaglan.AdminDb.FirstOrDefault(x => x.AdminAdi == admin.AdminAdi && x.AdminSifre == admin.AdminSifre);
            if (giris != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,admin.AdminAdi)
                };

                var useridentity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Admin","Admin");
            }
            return View();
        }


        public async Task<IActionResult> Cikis()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index","Home");
        }
    }
}
