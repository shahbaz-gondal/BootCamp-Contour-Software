using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RSS.Business.DataServices;
using RSS.Business.Interfaces;
using RSS.Business.Models;

namespace RSS.WebApp.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestService _requestService;
        public RequestController(IRequestService requestService)
        {
            _requestService = requestService;
        }
        // GET: RequestController
        public ActionResult GetAllRequests(string? fromCity, string? toCity)
        {
            if (fromCity == null || toCity == null)
            {
                return View(_requestService.GetAll());
            }
            else
            {
                return View(_requestService.SearchRequest(fromCity, toCity));
            }
        }
        public ActionResult Index()
        {
           
            return View(_requestService.GetAll());
        }

        // GET: RequestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RequestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RequestModel model)
        {
            try
            {
                _requestService.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RequestController/Edit/5
        public ActionResult Edit(int id)
        {
            var request = _requestService.GetAll().Where(x => x.Id == id).FirstOrDefault();
            return View(request);
        }

        // POST: RequestController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RequestModel model)
        {
            try
            {
                _requestService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RequestController/Delete/5
        public ActionResult Delete(int id)
        {
            _requestService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
