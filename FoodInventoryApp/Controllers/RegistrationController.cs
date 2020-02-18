using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodInventoryApp.Database;
using FoodInventoryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodInventoryApp.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //TODO: Choose an encryption or hashing method to more securely store passwords in the database as opposed to plaintext
        [HttpPost]
        public IActionResult RegisterUser(Registration registrationInfo)
        {
            if (registrationInfo.Username == null)
            {
                return View("Index");
            }

            if (registrationInfo.Password == null)
            {
                return View("Index");
            }

            using (var context = new FoodInventoryContext())
            {
                var user = new User()
                {
                    Username = registrationInfo.Username,
                    Password = registrationInfo.Password
                };
                context.Users.Add(user);
                context.SaveChanges();
            }

            return View();
        }
    }
}