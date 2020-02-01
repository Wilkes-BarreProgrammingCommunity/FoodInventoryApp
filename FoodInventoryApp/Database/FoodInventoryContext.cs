using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FoodInventoryApp.Database
{
    public partial class FoodInventoryContext : DbContext
    {
        public FoodInventoryContext(DbContextOptions<FoodInventoryContext> options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<InventoryLine> InventoryLines { get; set; }
        public DbSet<UserInventoryMapping> UserInventoryMappings { get; set; }
    }
}
