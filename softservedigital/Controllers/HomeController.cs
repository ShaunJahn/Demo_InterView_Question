using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using softservedigital.Controllers.Repository;
using softservedigital.ViewModels;

namespace softservedigital.Controllers
{
    public class HomeController : Controller
    {
        private IUser _UserRepository;

        public HomeController(IUser user)
        {
            _UserRepository = user;
        }

        public IActionResult Index()
        {
            var getAll = new HomeViewAllViewModel()
            {
                Users = _UserRepository.GetAllUsers()
            };


            return View(getAll);
        }
    }
}