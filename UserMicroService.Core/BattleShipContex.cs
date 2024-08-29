using Microsoft.EntityFrameworkCore;
using UserMicroService.Core.Models;

namespace UserMicroService.Core
{
    public class BattleShipContex(DbContextOptions<BattleShipContex> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Raitimg> Raitimgs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
