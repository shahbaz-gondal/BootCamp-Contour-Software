using Microsoft.AspNetCore.Authorization;
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
        const string SessionId = "_Id";
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

        [Authorize]
        public ActionResult GetmyRequests()
        {
            int id = (int)HttpContext.Session.GetInt32(SessionId);
            return View(_requestService.myRequests(id));
        }

        [Authorize]
        // GET: RequestController/Create
        public ActionResult Create()
        {
            ViewData["Id"] = (int)HttpContext.Session.GetInt32(SessionId);
            return View();
        }
        // POST: RequestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(RequestModel model)
        {
            try
            {
                _requestService.Add(model);
                return RedirectToAction("GetmyRequests");
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        // GET: RequestController/Edit/5
        public ActionResult Edit(int id)
        {
            var request = _requestService.GetAll().Where(x => x.Id == id).FirstOrDefault();
            ViewData["Id"] = (int)HttpContext.Session.GetInt32(SessionId);
            return View(request);
        }

        // POST: RequestController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit(RequestModel model)
        {
            try
            {
                _requestService.Update(model);
                return RedirectToAction("GetmyRequests");
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        // GET: RequestController/Delete/5
        public ActionResult Delete(int id)
        {
            _requestService.Delete(id);
            return RedirectToAction("GetmyRequests");
        }
        public ActionResult Details(int id)
        {
            var Details = _requestService.GetAll().Where(x => x.Id == id).FirstOrDefault();
            return View(Details);
        }
    }
}
