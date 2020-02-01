using System;
using System.Collections.Generic;

namespace FoodInventoryApp.Database
{
    public partial class UserInventoryMapping
    {
        public int Id { get; set; }
        public User User { get; set; }
        public InventoryLine InventoryLine { get; set; }
    }
}
