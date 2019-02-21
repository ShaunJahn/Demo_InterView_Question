using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using softservedigital.Controllers.Repository;
using softservedigital.ViewModels;

namespace softservedigital.Controllers
{
    public class SingleUserController : Controller
    {
        private IUser _UserRepository;

        public SingleUserController(IUser user)
        {
            _UserRepository = user;
        }


        [Route("SingleUser/{Id}")]
        public IActionResult SingleUser(int Id)
        {
            var userOut = new SingleUserViewModel()
            {
                SingleUser = _UserRepository.GetUserById(Id)
            };

            return View(userOut);
        }
    }
}