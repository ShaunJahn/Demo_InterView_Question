using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using softservedigital.Models;
using softservedigital.DbContexts;

namespace softservedigital.Controllers.Repository
{
    public class UserRepository : IUser
    {
        private UserDbContext _Context;

        public UserRepository(UserDbContext userDb)
        {
            _Context = userDb;
        }
        public IEnumerable<UserDto> GetAllUsers()
        {
            return _Context.Users.ToList();
        }

        public UserDto GetUserById(int IdNum)
        {
            return _Context.Users.Where(c => c.Id == IdNum).FirstOrDefault();
        }
    }
}
