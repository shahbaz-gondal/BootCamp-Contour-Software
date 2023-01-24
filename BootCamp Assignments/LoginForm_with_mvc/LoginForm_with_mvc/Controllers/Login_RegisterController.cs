using LoginForm_with_mvc.Models;
using LoginForm_with_mvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginForm_with_mvc.Controllers
{
    public class Login_RegisterController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Login(Login_RegisterModel model)
        {
            bool res = Login_RegisterService.ValidateUser(model);
            if (model.Email == null || model.Password == null)
            {
                return View();
            }
            else if (res == true)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["error"] = "Account not Found, Please Register Yourself";
                return View();
            }
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Login_RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Login_RegisterService.Add(model);
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForgotPassword(String u_email)
        {
            if(Login_RegisterService.FindPassword(u_email) != "invalid")
            {
                ViewData["password"] = "Your Password is: " + Login_RegisterService.FindPassword(u_email);
                return View();
            }
            else
            {
                ViewData["error"] = "Account not Found";
                return View();
            }
        }
    }
}
