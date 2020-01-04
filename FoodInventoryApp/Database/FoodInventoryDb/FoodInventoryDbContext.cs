using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodInventoryApp.Database.FoodInventoryDb
{
    public class FoodInventoryDbContext : DbContext
    {
        public FoodInventoryDbContext(DbContextOptions<FoodInventoryDbContext> options) : base(options)
        {

        }

        //TO-DO Finish context
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventoryLineEntity>(e =>
            {
            });
        }
    }
}
