using Microsoft.EntityFrameworkCore;
using MVC_02.Entites;

namespace MVC_02.Context
{
    public class GymDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        #region DBsets
        public DbSet<Trainer> Trainers { get; set; } = default!;
        public DbSet<Member> Members { get; set; } = default!;
        public DbSet<Session> Sessions { get; set; } = default!;
        public DbSet<Plan> Plans { get; set; } = default!;
        public DbSet<Membership> Memberships { get; set; } = default!;


        #endregion
    }
}
