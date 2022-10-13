#pragma warning disable CS8618  

using Microsoft.EntityFrameworkCore;
namespace chefs_and_dishes.Models;

public class chefs_and_dishesContext : DbContext
    {
        public chefs_and_dishesContext (DbContextOptions options) : base(options) {}

        public DbSet<Chefs> Chefs { get; set;}

        public DbSet<Dishes> Dishes { get; set; }
    }