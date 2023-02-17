using Microsoft.AspNetCore.Mvc;
using RSS.Business.Models;
using RSS.WebApp.Models;
using System.Diagnostics;

namespace RSS.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(UserModel model)
        {
            ViewBag.name = HttpContext.Session.GetString("name");
            if(model == null)
            {
                return View();
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}