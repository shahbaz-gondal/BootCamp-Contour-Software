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
        // GET: OfferController
        public ActionResult Index()
        {
            return View(_offerService.GetAll());
        }

        // GET: OfferController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OfferController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OfferModel model)
        {
            try
            {
                _offerService.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OfferController/Edit/5
        public ActionResult Edit(int id)
        {
            var offer = _offerService.GetAll().Where(x => x.Id == id).FirstOrDefault();
            return View(offer);
        }

        // POST: OfferController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OfferModel model)
        {
            try
            {
                _offerService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OfferController/Delete/5
        public ActionResult Delete(int id)
        {
            _offerService.Delete(id);
            return View();
        }
    }
}
