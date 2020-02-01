using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodInventoryApp.Database
{
    public class InventoryLine
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Unit { get; set; }
        public float Qty { get; set; }
        public DateTime Expiration { get; set; }

    }
}
