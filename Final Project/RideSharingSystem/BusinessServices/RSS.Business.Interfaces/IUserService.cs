using RSS.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS.Business.Interfaces
{
    public interface IUserService
    {
        public bool Register(UserModel model);
        public bool Login(UserModel model);
    }
}
