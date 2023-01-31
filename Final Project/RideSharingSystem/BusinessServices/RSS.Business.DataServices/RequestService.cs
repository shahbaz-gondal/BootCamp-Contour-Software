﻿using RSS.Business.Interfaces;
using RSS.Business.Models;
using RSS.Data;

namespace RSS.Business.DataServices
{
    public class RequestService:IRequestService
    {
        private readonly RideSharingDbContext _DBcontext;
        public RequestService(RideSharingDbContext DBcontext)
        {
            _DBcontext = DBcontext;
        }
        public List<RequestModel> GetAll()
        {
            var allRequestsList = _DBcontext.Requests.ToList();
            var RequestsList = allRequestsList.Select(x => new RequestModel
            {
                Id = x.Id,
                FromCity = x.FromCity,
                ToCity = x.ToCity,
                DepartureDateTime = x.DepartureDateTime
            }).ToList();
            return RequestsList;
        }
        public List<RequestModel> SearchRequest(string fromCity, string toCity)
        {
            fromCity = fromCity.Trim().ToLower();
            toCity = toCity.Trim().ToLower();
            var allRequests = _DBcontext.Requests.Where(x => x.FromCity.ToLower().Contains(fromCity)
            && x.ToCity.ToLower().Contains(toCity)).ToList();

            var searchRequests = allRequests.Select(x => new RequestModel
            {
                Id = x.Id,
                FromCity = x.FromCity,
                ToCity = x.ToCity,
                DepartureDateTime = x.DepartureDateTime
            }).ToList();
            return searchRequests;
        }
        public void Add(RequestModel model)
        {
            _DBcontext.Requests.Add(new Data.Models.Request { Id=model.Id,FromCity=model.FromCity,
            ToCity=model.ToCity,DepartureDateTime=model.DepartureDateTime});
            _DBcontext.SaveChanges();
        }
        public void Update(RequestModel model)
        {
            var entity = _DBcontext.Requests.FirstOrDefault(x => x.Id == model.Id);
            if(entity != null)
            {
                entity.FromCity = model.FromCity;
                entity.ToCity = model.ToCity;
                entity.DepartureDateTime = model.DepartureDateTime;
                _DBcontext.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var request = _DBcontext.Requests.Where(x=>x.Id==id).FirstOrDefault();
            if(request != null)
            {
                _DBcontext.Requests.Remove(request);
                _DBcontext.SaveChanges();
            }
        }
    }
}