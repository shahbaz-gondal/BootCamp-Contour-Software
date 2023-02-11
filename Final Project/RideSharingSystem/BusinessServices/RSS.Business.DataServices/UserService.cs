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
    public class UserService : IUserService
    {
        private readonly RideSharingDbContext _DBContext;
        public UserService(RideSharingDbContext dBContext)
        {
            _DBContext = dBContext;
        }

        public bool Register(UserModel model)
        {
            var email = _DBContext.Users.Where(x => x.Email == model.Email).FirstOrDefault();
            if (email == null)
            {
                _DBContext.Users.Add(new Data.Models.User
                {
                    Id = model.Id,
                    FullName = model.FullName,
                    Number = model.Number,
                    Gender = model.Gender,
                    Email = model.Email,
                    Password = model.Password
                });
                _DBContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Login(UserModel model)
        {
            var valid = _DBContext.Users.Where(x => x.Email == model.Email && x.Password == model.Password).FirstOrDefault();
            if (valid != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
