using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RSS.Business.DataServices;
using RSS.Business.Interfaces;
using RSS.Business.Models;

namespace RSS.WebApp.Controllers
{
    public class OfferController : Controller
    {
        private readonly IOfferService _offerService;
        const string SessionId = "_Id";
        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }
        public ActionResult GetAllOffers(string? fromCity, string? toCity)
        {
            if (fromCity == null || toCity == null)
            {
                return View(_offerService.GetAll());
            }
            else
            {
                return View(_offerService.SearchRequest(fromCity, toCity));
            }
        }
        [Authorize]
        // GET: OfferController
        public ActionResult GetmyOffers()
        {
            int id = (int)HttpContext.Session.GetInt32(SessionId);
            return View(_offerService.myOffers(id));
        }

        [Authorize]
        // GET: OfferController/Create
        public ActionResult Create()
        {
            ViewData["Id"] = (int)HttpContext.Session.GetInt32(SessionId);
            return View();
        }

        // POST: OfferController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(OfferModel model)
        {
            try
            {
                _offerService.Add(model);
                return RedirectToAction("GetmyOffers");
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        // GET: OfferController/Edit/5
        public ActionResult Edit(int id)
        {
            var offer = _offerService.GetAll().Where(x => x.Id == id).FirstOrDefault();
            ViewData["Id"] = (int)HttpContext.Session.GetInt32(SessionId);
            return View(offer);
        }

        [Authorize]
        // POST: OfferController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OfferModel model)
        {
            try
            {
                _offerService.Update(model);
                return RedirectToAction("GetmyOffers");
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        // GET: OfferController/Delete/5
        public ActionResult Delete(int id)
        {
            _offerService.Delete(id);
            return RedirectToAction("GetmyOffers");
        }

        [Authorize]
        public ActionResult Details(int id)
        {
            var Details = _offerService.GetAll().Where(x => x.Id == id).FirstOrDefault();
            return View(Details);
        }
    }
}
