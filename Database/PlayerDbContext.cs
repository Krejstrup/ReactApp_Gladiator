using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReactApp.Models.Data;

namespace ReactApp.Database
{
    public class PlayerDbContext : IdentityDbContext<GameUser>
    {

        public PlayerDbContext(DbContextOptions<PlayerDbContext> options) : base(options)
        { }


        public DbSet<Player> Players { get; set; }

        public DbSet<Gladiator> Gladiators { get; set; }

        public DbSet<Weapon> Weapons { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
