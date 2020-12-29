using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using AndrewPino.Models;
using BotDetect.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AndrewPino.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [Route("Resume")]
        public IActionResult Resume()
        {
            return View();
        }
        
        [Route("Research")]
        public IActionResult Research()
        {
            return View();
        }
        
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("Submission"), HttpPost, ValidateAntiForgeryToken]
        // [CaptchaValidationActionFilter("CaptchaCode", "AndrewPinoCaptcha", "Incorrect CAPTCHA code")]
        public IActionResult Submission(ContactFormModel model)
        {
//            if (ModelState.IsValid)
//            {
//                MvcCaptcha.ResetCaptcha("AndrewPinoCaptcha"); 
//                
//                MailMessage mailObj = new MailMessage(
//                    model.Email, "andrew@andrewpino.com", model.Subject, $"Name: {model.Name}\r\n\r\n{model.Message}");
//                SmtpClient smtpServer = new SmtpClient("127.0.0.1");
//                try
//                {
//                    smtpServer.Send(mailObj);
//                }
//                catch (Exception ex)
//                {
//                    var errorModel = new ErrorViewModel {Message = ex.Message};
//                    return View("Error", errorModel);
//                }
//                return View();
//            }
//            
//            var captchaErrorModel = new ErrorViewModel {Message = "Incorrect CAPTCHA code"};
//            return View("Error", captchaErrorModel);
            MailMessage mailObj = new MailMessage(
                model.Email, "andrew@andrewpino.com", model.Subject, $"Name: {model.Name}\r\n\r\n{model.Message}");
            SmtpClient smtpServer = new SmtpClient("127.0.0.1");
            try
            {
                smtpServer.Send(mailObj);
            }
            catch (Exception ex)
            {
                var errorModel = new ErrorViewModel {Message = ex.Message};
                return View("Error", errorModel);
            }
            return View();
        }
        
        [Route("Projects")]
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult References()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}