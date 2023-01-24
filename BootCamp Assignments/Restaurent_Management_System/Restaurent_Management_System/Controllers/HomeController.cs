using Microsoft.AspNetCore.Mvc;
using Restaurent_Management_System.Data;
using Restaurent_Management_System.Models;
using System.Diagnostics;

namespace Restaurent_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RestaurantDBContext _DBcontext;
        public HomeController(ILogger<HomeController> logger, RestaurantDBContext dBcontext)
        {
            _logger = logger;
            _DBcontext = dBcontext; 
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(BookingModel model)
        {
            _DBcontext.TablBookings.Add(model);
            _DBcontext.SaveChanges();
            return View();
        }
        public IActionResult AllBookings()
        {
            List<BookingModel> allBookingsList = _DBcontext.TablBookings.ToList();
            return View(allBookingsList);
        }
        public IActionResult Update(int Id)
        {
            BookingModel BookingDetails = _DBcontext.TablBookings.FirstOrDefault(x => x.Id == Id);
            return View(BookingDetails);
        }
        [HttpPost]
        public IActionResult Update(BookingModel model)
        {
            _DBcontext.TablBookings.Update(model);
            _DBcontext.SaveChanges();
            return RedirectToAction("AllBookings");
        }
        public IActionResult Delete(int Id)
        {
            BookingModel BookingDetails = _DBcontext.TablBookings.FirstOrDefault(x => x.Id == Id);
            _DBcontext.TablBookings.Remove(BookingDetails);
            _DBcontext.SaveChanges();
            return RedirectToAction("AllBookings");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}