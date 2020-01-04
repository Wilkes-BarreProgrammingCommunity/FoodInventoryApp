using System;
using System.ComponentModel.DataAnnotations;

namespace FoodInventoryApp.Models
{
    public class InventoryItem
    {
        public Guid Id;
        public string Name { get; set; }
        public decimal Qty { get; set; }
        public string UnitsOfMeasurement { get; set; }
        public string Location { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }
    }
}
