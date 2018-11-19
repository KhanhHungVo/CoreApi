using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApi.Entities;

namespace CoreApi.Services
{
    public class UserService : IUserService
    {
        public User Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
