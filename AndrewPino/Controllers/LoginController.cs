using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AndrewPino.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace AndrewPino.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly LoginMessage _loginMessage = new();
        
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public IActionResult Index()
        {
            return View(_loginMessage);
        }
        
        [HttpPost]
        public async Task<IActionResult> Login([FromForm] string userName, [FromForm] string password, string returnUrl)
        {
            var user = _configuration.GetSection("BlogUser").Get<BlogUser>();
            
            if (String.Equals(userName, user.UserName, StringComparison.CurrentCultureIgnoreCase))
            {
                var passwordHasher = new PasswordHasher<string>();
                if (passwordHasher.VerifyHashedPassword(null, user.Password, password) == PasswordVerificationResult.Success)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, userName)
                    };
                    
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    return Redirect(returnUrl);
                }
            }
            
            _loginMessage.Message = "Invalid Attempt";
            
            return View("Index", _loginMessage);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}