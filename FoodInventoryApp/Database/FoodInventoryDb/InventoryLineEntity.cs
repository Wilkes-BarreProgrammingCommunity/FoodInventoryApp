using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodInventoryApp.Database.FoodInventoryDb
{
    public class InventoryLineEntity
    {
        public int InventoryId { get; set; }
        public int UserId { get; set; }
        public string FoodName { get; set; }
        public string Location { get; set; }
        public decimal Qty { get; set; }
        public string Unit { get; set; }
        [DataType(DataType.Date)]
        public DateTime Expiration { get; set; }

    }
}
