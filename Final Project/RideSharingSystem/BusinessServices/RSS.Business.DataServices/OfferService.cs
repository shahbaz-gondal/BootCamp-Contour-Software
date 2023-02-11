using Microsoft.EntityFrameworkCore;
using RSS.Business.Interfaces;
using RSS.Business.Models;
using RSS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS.Business.DataServices
{
    public class OfferService : IOfferService
    {
        private readonly RideSharingDbContext _DbContext;
        public OfferService(RideSharingDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public List<OfferModel> GetAll()
        {
            var allOffersList = _DbContext.Offers.ToList();
            var OffersList = allOffersList.Select(x => new OfferModel
            {
                Id = x.Id,
                FromCity = x.FromCity,
                ToCity = x.ToCity,
                DepartureDateTime = x.DepartureDateTime,
                Cost = x.Cost
            }).ToList();
            return OffersList;
        }
        public List<OfferModel> SearchRequest(string fromCity, string toCity)
        {
            fromCity = fromCity.Trim().ToLower();
            toCity = toCity.Trim().ToLower();
            var allOffers = _DbContext.Offers.Where(x => x.FromCity.ToLower().Contains(fromCity)
            && x.ToCity.ToLower().Contains(toCity)).ToList();
            var searchOffers = allOffers.Select(x => new OfferModel
            {
                Id = x.Id,
                FromCity = x.FromCity,
                ToCity = x.ToCity,
                DepartureDateTime = x.DepartureDateTime,
                Cost = x.Cost
            }).ToList();
            return searchOffers;
        }
        public void Add(OfferModel model)
        {
            _DbContext.Offers.Add(new Data.Models.Offer
            {
                Id = model.Id,
                FromCity = model.FromCity,
                ToCity = model.ToCity,
                DepartureDateTime = model.DepartureDateTime,
                Cost = model.Cost
            });
            _DbContext.SaveChanges();
        }
        public void Update(OfferModel model)
        {
            var entity = _DbContext.Offers.FirstOrDefault(x => x.Id == model.Id);
            if (entity != null)
            {
                entity.FromCity = model.FromCity;
                entity.ToCity = model.ToCity;
                entity.DepartureDateTime = model.DepartureDateTime;
                entity.Cost = model.Cost;
                _DbContext.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var offer = _DbContext.Offers.Where(x => x.Id == id).FirstOrDefault();
            if (offer != null)
            {
                _DbContext.Offers.Remove(offer);
                _DbContext.SaveChanges();
            }
        }
    }
}
