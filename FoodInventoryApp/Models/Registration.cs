using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodInventoryApp.Models
{
    public class Registration
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string ErrorMessage { get; set; }
    }
}
