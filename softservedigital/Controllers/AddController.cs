using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using softservedigital.ViewModels;
using softservedigital.DbContexts;
using softservedigital.Models;

namespace softservedigital.Controllers
{
    public class AddController : Controller
    {
        private UserDbContext _Context;

        public AddController(UserDbContext userDb)
        {
            _Context = userDb;

        }
        public IActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNew(AddNewViewModel AddUser)
        {
            if (ModelState.IsValid)
            {
                var newUser = new UserDto()
                {
                    FirstName = AddUser.FirstName,
                    Surname = AddUser.Surname,
                    Age = AddUser.Age,
                    BirthDate = AddUser.BirthDate.Date,
                    Salary = AddUser.Salary
                };

                _Context.Users.Add(newUser);
                _Context.SaveChanges();


                return RedirectToAction("Index", "Home");
            }
            return View(AddUser);
        }
    }
}