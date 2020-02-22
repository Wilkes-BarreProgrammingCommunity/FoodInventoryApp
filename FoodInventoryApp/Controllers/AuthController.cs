using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodInventoryApp.Database;
using FoodInventoryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodInventoryApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Registration(Registration registration)
        {

            return PartialView("_Registration", registration);
        }

        //TODO: Choose an encryption or hashing method to more securely store passwords in the database as opposed to plaintext
        [HttpPost]
        public IActionResult RegisterUser(Registration registrationInfo)
        {
            if (registrationInfo.Username == null)
            {
                registrationInfo.ErrorMessage = "Please input a user name.";
                return PartialView("_Registration", registrationInfo);
            }

            if (registrationInfo.Password == null)
            {
                registrationInfo.ErrorMessage = "Please input a password.";
                return PartialView("_Registration", registrationInfo);
            }

            //if (username in database) message = username already taken

            if (registrationInfo.Password != registrationInfo.ConfirmPassword)
            {
                registrationInfo.ErrorMessage = "The input passwords do not match";
                return PartialView("_Registration", registrationInfo);
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