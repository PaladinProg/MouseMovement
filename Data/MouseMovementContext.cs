using Microsoft.EntityFrameworkCore;

namespace MouseMovement.Data
{
    public class MouseMovementContext : DbContext
    {

        public MouseMovementContext(DbContextOptions<MouseMovementContext> options)
            : base(options)
        {
        }

        public DbSet<MouseMovement> MouseMovements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionString");
        }
    }
}
