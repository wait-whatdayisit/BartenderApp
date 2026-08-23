using Microsoft.EntityFrameworkCore;
using BartenderApp.Models;

namespace BartenderApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Drink> Drinks { get; set; }
    }
}