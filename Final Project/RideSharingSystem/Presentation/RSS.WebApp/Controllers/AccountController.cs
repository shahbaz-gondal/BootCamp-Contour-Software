using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RSS.Business.Interfaces;
using RSS.Business.Models;


namespace RSS.WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: AccountController
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserModel model)
        {
            var message = _userService.Register(model);
            if (message == false)
            {
                TempData["message"] = "Email Already Registered";
                return View();
            }
            else
            {
                return RedirectToAction("LogIn");
            }
        }

        // GET: AccountController/Create
        public ActionResult LogIn()
        {
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(UserModel model)
        {
            var valid = _userService.Login(model);
            if(valid == true)
            {
                
            }
            return View();
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
