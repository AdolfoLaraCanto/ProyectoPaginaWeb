using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace InventarioPaginaWeb.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login (string return_url)
        {
            if (return_url != null)
                ViewData.Add ("return_url", HtmlEncoder.Default.Encode (return_url));
            else
                ViewData.Add ("return_url", "");

            return View ();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Login(InventarioPaginaWeb.Models.LoginModel model)
        {
            if (model.Email == "user@gmail.com" && model.Password == "password")
            {
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, model.Email));

                var userIdentity = new ClaimsIdentity(claims, "login");
                var principal = new ClaimsPrincipal(userIdentity);
                HttpContext.SignInAsync("PKAT", principal);

                //prevenimos el open redirection attack
                if (Url.IsLocalUrl(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            if (model.Email == "example@hotmail.com" && model.Password == "cisco")
            {
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, model.Email));

                var userIdentity = new ClaimsIdentity(claims, "login");
                var principal = new ClaimsPrincipal(userIdentity);
                HttpContext.SignInAsync("PKAT", principal);

                //prevenimos el open redirection attack
                if (Url.IsLocalUrl(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        bool LoginUser (string username, string password)
        {
            return true;
        }

        [HttpGet]
        public IActionResult Logout ()
        {
            HttpContext.SignOutAsync ("PKAT");
            return Redirect ("/Account/Login");
        }

    }
}