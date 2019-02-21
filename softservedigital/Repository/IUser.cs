using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using softservedigital.Models;

namespace softservedigital.Controllers.Repository
{
    public interface IUser
    {
        IEnumerable<UserDto> GetAllUsers();
        UserDto GetUserById(int IdNum);
    }
}
