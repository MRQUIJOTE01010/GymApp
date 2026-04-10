using Microsoft.EntityFrameworkCore;
using GymApp.Models;

namespace GymApp.Database
{
    public class GymDbContext : DbContext
    {
        public DbSet<Miembro> Miembros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=gym.db");
        }
    }
}
